using UnityEngine;

namespace Scenes.Demo._05_MergePuzzleGame
{
    public class BubbleController : MonoBehaviour
    {
        // シーンディレクター
        public MergePuzzleSceneDirector _sceneDirector;
        // カラー
        public int _colorType;
        // マージ済フラグ
        public bool _isMerged;

        void Update()
        {
            // 画面外に落ちたら消す
            if(transform.position.y < -10)
            {
                Destroy(gameObject);
            }
        }
        
        // 当たり判定が発生したら呼ばれる
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // バブルじゃない
            BubbleController bubble =
                collision.gameObject.GetComponent<BubbleController>();
            if (!bubble) return;

            // 合体させる
            _sceneDirector.Merge(this, bubble);
        }
    }
}
