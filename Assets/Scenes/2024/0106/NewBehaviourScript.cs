using UnityEngine;
using UnityEngine.UI;

namespace Scenes._2024._0106
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Toggle _toggle;
        
        // Start is called before the first frame update
        void Start()
        {
            // Toggleの状態を取得
            Debug.Log(_toggle.isOn);
            
            // Toggleの状態を変更
            _toggle.isOn = false;
            
            // Toggleの状態を変更
            Debug.Log(_toggle.isOn);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
