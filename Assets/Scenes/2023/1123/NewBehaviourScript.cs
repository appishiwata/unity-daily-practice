using UnityEngine;
using UnityEngine.UI;

namespace Scenes._1123
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Image _image;
        
        void Start()
        {
            // 変数
            _image.color = Color.red;
            _image.raycastTarget = false;
            _image.maskable = false;
            _image.canvasRenderer.SetAlpha(0.5f);
        }
    }
}
