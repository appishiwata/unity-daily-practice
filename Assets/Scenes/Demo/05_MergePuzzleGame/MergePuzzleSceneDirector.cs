using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Scenes.Demo._05_MergePuzzleGame
{
    public class MergePuzzleSceneDirector : MonoBehaviour
    {
        // アイテムのプレハブ
        [SerializeField] List<BubbleController> prefabBubbles;
        // UI
        [SerializeField] TextMeshProUGUI textScore;
        [SerializeField] GameObject panelResult;

        // スコア
        int score;
        // 現在のアイテム
        BubbleController currentBubble;
        // 生成位置
        const float SpawnItemY = 3.5f;

        // Start is called before the first frame update
        void Start()
        {
            // リザルト画面を非表示
            panelResult.SetActive(false);

            // 最初のアイテムを生成
            StartCoroutine(SpawnCurrentItem());
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        // アイテム生成
        BubbleController SpawnItem(Vector2 position, int colorType = -1)
        {
            // 色ランダム
            int index = Random.Range(0, prefabBubbles.Count / 2);

            // 色の指定があれば上書き
            if(0 < colorType)
            {
                index = colorType;
            }

            // 生成
            BubbleController bubble =
                Instantiate(prefabBubbles[index], position, Quaternion.identity);

            // 必須データセット
            bubble.SceneDirector = this;
            bubble.ColorType = index;

            return bubble;
        }

        // 所持アイテム生成
        IEnumerator SpawnCurrentItem()
        {
            // 指定された秒数待つ
            yield return new WaitForSeconds(1.0f);
            // 生成されたアイテムを保持する
            currentBubble = SpawnItem(new Vector2(0, SpawnItemY));
            // 落ちないように重力を0にする
            currentBubble.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }
}
