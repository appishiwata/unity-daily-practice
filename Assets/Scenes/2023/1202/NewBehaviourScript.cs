using UnityEngine;

namespace Scenes._1202
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameObject _gameObject;
        
        void Start()
        {
            // =====================================
            // GameObjectのPublic関数
            // =====================================

            // AddComponent関数
            _gameObject.AddComponent<Rigidbody>();
            
            // GetComponent関数
            var rigidbody = _gameObject.GetComponent<Rigidbody>();
            
            Debug.LogFormat("rigidbody: {0}", rigidbody);
            
            // TryGetComponent関数
            if (_gameObject.TryGetComponent<Rigidbody>(out var rigidbodyTry))
            {
                Debug.LogFormat("rigidbodyTry: {0}", rigidbodyTry);
            }
            else
            {
                Debug.Log("rigidbodyTry: null");
            }
            
            // =====================================
            // GameObjectのStatic関数
            // =====================================
            
            // Find関数
            var gameObject = GameObject.Find("GameObject");
            Debug.LogFormat("gameObject: {0}", gameObject);
        }
    }
}
