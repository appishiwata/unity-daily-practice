using UnityEngine;
using UnityEngine.UI;

namespace Scenes._2024._0108
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Scrollbar _scrollbar;
        
        // Start is called before the first frame update
        void Start()
        {
            // Scrollbarの値を取得
            Debug.Log(_scrollbar.value);
            
            // Scrollbarの値を変更
            _scrollbar.value = 0.5f;
            
            // Scrollbarの値を変更
            Debug.Log(_scrollbar.value);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
