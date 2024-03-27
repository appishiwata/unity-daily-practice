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
    }
}
