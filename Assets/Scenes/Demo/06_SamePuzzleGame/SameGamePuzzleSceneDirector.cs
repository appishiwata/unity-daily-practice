using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Demo._06_SamePuzzleGame
{
    public class SameGamePuzzleSceneDirector : MonoBehaviour
    {
        // アイテムのプレハブ
        [SerializeField] List<GameObject> prefabBubbles;
        // ゲーム時間
        [SerializeField] float gameTimer;
        // フィールドのアイテム総数
        [SerializeField] int fieldItemCountMax;
        // 削除できるアイテム数
        [SerializeField] int deleteCount;

        // UI
        [SerializeField] TextMeshProUGUI textGameScore;
        [SerializeField] TextMeshProUGUI textGameTimer;
        [SerializeField] GameObject panelGameResult;
        // Audio
        [SerializeField] AudioClip seBubble;
        [SerializeField] AudioClip seSpecial;

        // フィールド上のアイテム
        List<GameObject> bubbles;
        // スコア
        int gameScore;
        // 再生装置
        AudioSource audioSource;
        
        // ツムツム風
        List<GameObject> lineBubbles;
        LineRenderer lineRenderer;

        // Start is called before the first frame update
        void Start()
        {
            // Audio
            audioSource = GetComponent<AudioSource>();

            // 全アイテム
            bubbles = new List<GameObject>();

            // ツムツム風
            lineBubbles = new List<GameObject>();
            // 連結したアイテム上のライン
            lineRenderer = GetComponent<LineRenderer>();

            // リザルト画面非表示
            panelGameResult.SetActive(false);

            // アイテム生成
            SpawnItem(fieldItemCountMax);
        }

        // Update is called once per frame
        void Update()
        {
            // ゲームタイマー更新
            gameTimer -= Time.deltaTime;
            textGameTimer.text = "" + (int)gameTimer;

            // ゲーム終了
            if (0 > gameTimer)
            {
                // リザルト画面表示
                panelGameResult.SetActive(true);
                // Updateに入らないようにする
                enabled = false;
                // この時点でUpdateから抜ける
                return;
            }

            // タッチ開始
            if(Input.GetMouseButtonDown(0))
            {
                GameObject hitBubble = GetHitBubble();

                // 下準備
                lineBubbles.Clear();

                // 当たり判定あり
                if(hitBubble)
                {
                    lineBubbles.Add(hitBubble);
                }
            }
            // おしっぱなし
            else if(Input.GetMouseButton(0))
            {
                GameObject hitBubble = GetHitBubble();

                // 当たり判定あり
                if(hitBubble && lineBubbles.Count > 0)
                {
                    // 距離
                    GameObject pre = lineBubbles[lineBubbles.Count - 1];
                    float distance
                        = Vector2.Distance(hitBubble.transform.position, pre.transform.position);

                    // カラー
                    bool isSameColor
                        = hitBubble.GetComponent<SpriteRenderer>().sprite == pre.GetComponent<SpriteRenderer>().sprite;

                    if(isSameColor && distance <= 1.5f && !lineBubbles.Contains(hitBubble))
                    {
                        // ラインに追加
                        lineBubbles.Add(hitBubble);
                    }
                }
            }
            // タッチ終了
            else if (Input.GetMouseButtonUp(0))
            {
                // 削除されたアイテムをクリア
                bubbles.RemoveAll(item => item == null);

                // アイテム削除
                DeleteItems(lineBubbles);

                // ラインをクリア
                lineRenderer.positionCount = 0;
                lineBubbles.Clear();
            }

            // ライン描画
            if(lineBubbles.Count > 1)
            {
                // 頂点数
                lineRenderer.positionCount = lineBubbles.Count;
                // ラインのポジション
                for (int i = 0; i < lineBubbles.Count; i++)
                {
                    lineRenderer.SetPosition(i, lineBubbles[i].transform.position);
                }
            }

    /*
            // タッチ処理
            if(Input.GetMouseButtonUp(0))
            {
                GameObject hitBubble = GetHitBubble();

                // 削除されたアイテムをクリア
                bubbles.RemoveAll(item => item == null);

                // なにか当たり判定があれば
                if(hitBubble)
                {
                    CheckItems(hitBubble);
                }
            }
    */
        }

        // アイテム生成
        void SpawnItem(int count)
        {
            for (int i = 0; i < count; i++)
            {
                // 色ランダム
                int rnd = Random.Range(0, prefabBubbles.Count);
                // 場所ランダム
                float x = Random.Range(-2.0f, 2.0f);
                float y = Random.Range(-2.0f, 2.0f);

                // アイテム生成
                GameObject bubble =
                    Instantiate(prefabBubbles[rnd], new Vector3(x, 7 + y, 0), Quaternion.identity);

                // 内部データ追加
                bubbles.Add(bubble);
            }
        }

        // 引数と同じ色のアイテムを削除する
        void DeleteItems(List<GameObject> checkItems)
        {
            // 削除可能数に達していなかったらなにもしない
            if (checkItems.Count < deleteCount) return;

            // ボーナスとしてオーバーしたカウント*5個削除
            int overCount = checkItems.Count - deleteCount;
            overCount *= 5;

            // ランダムなアイテムを削除リストに追加（かぶりの可能性あり）
            while(overCount > 0)
            {
                int rnd = Random.Range(0, bubbles.Count);
                checkItems.Add(bubbles[rnd]);
                overCount--;

                // 最後の1個でSE再生
                if(overCount == 0)
                {
                    audioSource.PlayOneShot(seSpecial);
                }
            }


            // 削除してスコア加算
            List<GameObject> destroyItems = new List<GameObject>();
            foreach (var item in checkItems)
            {
                // かぶりなしの削除したアイテムをカウント
                if(!destroyItems.Contains(item))
                {
                    destroyItems.Add(item);
                }

                //削除
                Destroy(item);
            }

            // 実際に削除した分生成してスコア加算
            SpawnItem(destroyItems.Count);
            gameScore += destroyItems.Count * 100;

            // スコア表示更新
            textGameScore.text = "" + gameScore;

            // SE再生
            audioSource.PlayOneShot(seBubble);
        }

        // 同じ色のアイテムを返す
        List<GameObject> GetSameItems(GameObject target)
        {
            List<GameObject> ret = new List<GameObject>();

            foreach (var item in bubbles)
            {
                // アイテムがない、同じアイテム、違う色、距離が遠い場合はスキップ
                if (!item || target == item) continue;

                if(item.GetComponent<SpriteRenderer>().sprite
                    != target.GetComponent<SpriteRenderer>().sprite)
                {
                    continue;
                }

                float distance
                    = Vector2.Distance(target.transform.position, item.transform.position);

                if (distance > 1.1f) continue;

                // ここまできたらアイテム追加
                ret.Add(item);
            }

            return ret;
        }

        // 引数と同じ色のアイテムを探す
        void CheckItems(GameObject target)
        {
            // このアイテムと同じ色を追加する
            List<GameObject> checkItems = new List<GameObject>();
            // 自分を追加
            checkItems.Add(target);

            // チェック済のインデックス
            int checkIndex = 0;

            // checkItemsの最大値までループ
            while (checkIndex < checkItems.Count)
            {
                // 隣接する同じ色を取得
                List<GameObject> sameItems = GetSameItems(checkItems[checkIndex]);
                // チェック済のインデックスを進める
                checkIndex++;

                // まだ追加されていないアイテムを追加する
                foreach (var item in sameItems)
                {
                    if (checkItems.Contains(item)) continue;
                    checkItems.Add(item);
                }
            }

            // 削除
            DeleteItems(checkItems);
        }

        // マウスポジションに当たり判定があったバブルを返す
        GameObject GetHitBubble()
        {
            GameObject ret = null;

            // スクリーン座標からワールド座標に変換
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast(worldPoint, Vector2.zero);

            // 当たり判定あり
            if(hit2d)
            {
                // 画像が設定されていたらバブルアイテムと判断する
                SpriteRenderer spriteRenderer
                    = hit2d.collider.gameObject.GetComponent<SpriteRenderer>();

                if(spriteRenderer)
                {
                    ret = hit2d.collider.gameObject;
                }
            }

            return ret;
        }

        // リトライボタン
        public void OnClickRetry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
