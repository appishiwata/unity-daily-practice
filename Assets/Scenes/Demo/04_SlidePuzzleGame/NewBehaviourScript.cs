using System.Collections.Generic;
using UnityEngine;

namespace Scenes.Demo._04_SlidePuzzleGame
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // ピース
        [SerializeField] List<GameObject> pieces;
        // ゲームクリア時に表示されるボタン
        [SerializeField] GameObject buttonRetry;
        // シャッフル回数
        [SerializeField] int shuffleCount;

        // 初期位置
        List<Vector2> startPositions;

        // Start is called before the first frame update
        void Start()
        {
            // ボタン非表示
            buttonRetry.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
