using UnityEngine;
using UnityEngine.UI;

namespace Scenes._2024._0107
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Slider _slider;
        
        // Start is called before the first frame update
        void Start()
        {
            // Sliderの値を取得
            Debug.Log(_slider.value);
            
            // Sliderの値を変更
            _slider.value = 0.5f;
            
            // Sliderの値を変更
            Debug.Log(_slider.value);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
