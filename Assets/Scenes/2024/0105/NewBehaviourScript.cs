using UnityEngine;
using UnityEngine.UI;

namespace Scenes._2024._0105
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Image _panel;
        
        // Start is called before the first frame update
        void Start()
        {
            // Panelの色を変更
            _panel.color = new Color(1, 0, 0, 1);
            
            // Panelのアルファ値を変更
            _panel.color = new Color(1, 0, 0, 0.5f);
            
            // PanelはImageコンポーネントを持っていて、RectTransformがストレッチされている
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
