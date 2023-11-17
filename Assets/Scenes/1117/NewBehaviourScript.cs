using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._1117
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Image _image;
        [SerializeField] Image _target;
        [SerializeField] Image _middle;
        
        void Start()
        {
            var startPoint = _image.transform.position;
            var middlePoint = _middle.transform.position;
            var endPoint = _target.transform.position;
            
            // 通常の移動
            _image.transform.DOMove(endPoint, 2);
        }
    }
}
