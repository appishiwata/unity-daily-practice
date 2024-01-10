using UnityEngine;
using UnityEngine.UI;

namespace Scenes._2024._0110
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Button _button;
        
        // Start is called before the first frame update
        void Start()
        {
            // Buttonのクリックイベントを追加
            _button.onClick.AddListener(() =>
            {
                Debug.Log("Button Clicked");
            });
            
            _button.interactable = false;
            Debug.Log(_button.interactable);

            _button.interactable = true;
            Debug.Log(_button.interactable);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
