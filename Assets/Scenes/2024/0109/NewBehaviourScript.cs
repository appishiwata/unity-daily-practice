using UnityEngine;
using UnityEngine.UI;

namespace Scenes._2024._0109
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] ScrollRect _scrollView;
        
        // Start is called before the first frame update
        void Start()
        {
            // ScrollRectのスクロール範囲を取得
            Debug.Log(_scrollView.content.rect);
            
            // ScrollRectのスクロール範囲を変更
            _scrollView.content.sizeDelta = new Vector2(1000, 1000);
            
            // ScrollRectのスクロール範囲を変更
            Debug.Log(_scrollView.content.rect);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
