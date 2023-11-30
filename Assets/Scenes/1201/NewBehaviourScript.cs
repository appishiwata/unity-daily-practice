using UnityEngine;

namespace Scenes._1201
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameObject _gameObject;
        
        void Start()
        {
            // GameObjectクラスの変数
            Debug.LogFormat("GameObject: {0}", _gameObject.scene.name);
            Debug.LogFormat("tag: {0}, layer: {1}", _gameObject.tag, _gameObject.layer);
            Debug.LogFormat("activeSelf: {0}, activeInHierarchy: {1}", _gameObject.activeSelf, _gameObject.activeInHierarchy);
            
            // GameObjectクラスの関数
            _gameObject.SetActive(false);

            // 確認
            Debug.LogFormat("activeSelf: {0}, activeInHierarchy: {1}", _gameObject.activeSelf, _gameObject.activeInHierarchy);
        }
    }
}
