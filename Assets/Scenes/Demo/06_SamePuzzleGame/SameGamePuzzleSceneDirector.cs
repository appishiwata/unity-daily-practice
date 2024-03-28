using System.Collections.Generic;
using TMPro;
using UnityEngine;

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


        // Start is called before the first frame update
        void Start()
        {
            // 全アイテム
            bubbles = new List<GameObject>();

            // リザルト画面非表示
            panelGameResult.SetActive(false);

            // アイテム生成
            SpawnItem(fieldItemCountMax);
        }

        // Update is called once per frame
        void Update()
        {
            // タッチ処理
            if(Input.GetMouseButtonUp(0))
            {
                // スクリーン座標からワールド座標に変換
                Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit2d = Physics2D.Raycast(worldPoint, Vector2.zero);

                // 削除されたアイテムをクリア
                bubbles.RemoveAll(item => item == null);

                // なにか当たり判定があれば
                if(hit2d)
                {
                    // 当たり判定があったオブジェクト
                    GameObject obj = hit2d.collider.gameObject;
                    DeleteItems(obj);
                }
            }
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
        void DeleteItems(GameObject target)
        {
            // このアイテムと同じ色を追加する
            List<GameObject> checkItems = new List<GameObject>();
            // 自分を追加
            checkItems.Add(target);

            // TODO 全体のアイテムから同じ色を探す

            // 削除可能数に達していなかったらなにもしない
            if (checkItems.Count < deleteCount) return;

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
        }
    }
}
