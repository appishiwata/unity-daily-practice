using UnityEngine;

namespace Scenes.Demo._05_MergePuzzleGame
{
    public class BubbleController : MonoBehaviour
    {
        // シーンディレクター
        public MergePuzzleSceneDirector SceneDirector;
        // カラー
        public int ColorType;
        // マージ済フラグ
        public bool IsMerged;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            // 画面外に落ちたら消す
            if(transform.position.y < -10)
            {
                Destroy(gameObject);
            }
        }
    }
}
