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
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
