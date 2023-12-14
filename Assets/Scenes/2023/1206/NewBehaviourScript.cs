using UnityEngine;

namespace Scenes._1206
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Transform _transform;
        
        void Start()
        {
            // Transoformクラス : ゲームオブジェクトの位置、回転、スケールを管理するクラス
            
            _transform.position = new Vector3(1, 2, 3);
            _transform.rotation = Quaternion.Euler(0, 90, 0);
            _transform.localScale = new Vector3(2, 2, 2);
        }
    }
}
