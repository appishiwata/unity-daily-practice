using Unity.VisualScripting;
using UnityEngine;

namespace Scenes._1205
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Object _obj;
        
        void Start()
        {
            Debug.Log(_obj.name);
            _obj.GameObject().SetActive(false);
            
            // Objectクラス : Unity が参照できるすべてのオブジェクトの基本クラス
        }
    }
}
