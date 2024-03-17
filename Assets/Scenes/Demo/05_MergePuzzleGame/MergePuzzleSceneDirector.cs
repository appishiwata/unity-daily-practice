using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Demo._05_MergePuzzleGame
{
    public class MergePuzzleSceneDirector : MonoBehaviour
    {
        // アイテムのプレハブ
        [SerializeField] List<BubbleController> _prefabBubbles;
        // UI
        [SerializeField] TextMeshProUGUI _textScore;
        [SerializeField] GameObject _panelResult;
        // Audio
        [SerializeField] AudioClip _seDrop;
        [SerializeField] AudioClip _seMerge;
        
        // スコア
        int _score;
        // 現在のアイテム
        BubbleController _currentBubble;
        // 生成位置
        const float SpawnItemY = 3.5f;
        // Audio再生装置
        AudioSource _audioSource;

        void Start()
        {
            // サウンド再生用
            _audioSource = GetComponent<AudioSource>();

            // リザルト画面を非表示
            _panelResult.SetActive(false);

            // 最初のアイテムを生成
            StartCoroutine(SpawnCurrentItem());
        }

        void Update()
        {
            // アイテムがなければここから下の処理はしない
            if (!_currentBubble) return;

            // マウスポジション（スクリーン座標）からワールド座標に変換
            Vector2 worldPoint = Camera.main!.ScreenToWorldPoint(Input.mousePosition);

            // x座標をマウスに合わせる
            Vector2 bubblePosition = new Vector2(worldPoint.x, SpawnItemY);
            _currentBubble.transform.position = bubblePosition;

            // タッチ処理
            if(Input.GetMouseButtonUp(0))
            {
                // 重力をセットしてドロップ
                _currentBubble.GetComponent<Rigidbody2D>().gravityScale = 1;
                // 所持アイテムリセット
                _currentBubble = null;
                // 次のアイテム
                StartCoroutine(SpawnCurrentItem());
                // SE再生
                _audioSource.PlayOneShot(_seDrop);
            }
        }

        // アイテム生成
        BubbleController SpawnItem(Vector2 position, int colorType = -1)
        {
            // 色ランダム
            int index = Random.Range(0, _prefabBubbles.Count / 2);

            // 色の指定があれば上書き
            if(0 < colorType)
            {
                index = colorType;
            }

            // 生成
            BubbleController bubble =
                Instantiate(_prefabBubbles[index], position, Quaternion.identity);

            // 必須データセット
            bubble._sceneDirector = this;
            bubble._colorType = index;

            return bubble;
        }

        // 所持アイテム生成
        IEnumerator SpawnCurrentItem()
        {
            // 指定された秒数待つ
            yield return new WaitForSeconds(1.0f);
            // 生成されたアイテムを保持する
            _currentBubble = SpawnItem(new Vector2(0, SpawnItemY));
            // 落ちないように重力を0にする
            _currentBubble.GetComponent<Rigidbody2D>().gravityScale = 0;
        }

        // アイテムを合体させる
        public void Merge(BubbleController bubbleA, BubbleController bubbleB)
        {
            // 操作中のアイテムとぶつかったらゲームオーバー
            if(_currentBubble == bubbleA || _currentBubble == bubbleB)
            {
                // このUpdateに入らないようにする
                enabled = false;
                // リザルトパネル表示
                _panelResult.SetActive(true);

                return;
            }

            // マージ済
            if (bubbleA._isMerged || bubbleB._isMerged) return;

            // 違う色
            if (bubbleA._colorType != bubbleB._colorType) return;

            // 次に生成する色が用意してあるリストの最大数を超える
            int nextColor = bubbleA._colorType + 1;
            if (_prefabBubbles.Count - 1 < nextColor) return;

            // 2点間の中心
            Vector2 lerpPosition =
                Vector2.Lerp(bubbleA.transform.position, bubbleB.transform.position, 0.5f);

            // 新しいアイテムを生成
            BubbleController newBubble = SpawnItem(lerpPosition, nextColor);

            // マージ済フラグON
            bubbleA._isMerged = true;
            bubbleB._isMerged = true;

            // シーンから削除
            Destroy(bubbleA.gameObject);
            Destroy(bubbleB.gameObject);

            // 点数計算と表示更新
            _score += newBubble._colorType * 10;
            _textScore.text = "" + _score;

            // SE再生
            _audioSource.PlayOneShot(_seMerge);
        }

        // リトライボタン
        public void OnClickRetry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
