using UnityEngine;
using UnityEngine.UI;

namespace Scenes._1124
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Image _image;
        
        void Start()
        {
            _image.type = Image.Type.Filled;
            _image.fillAmount = 0.25f;
            _image.fillMethod = Image.FillMethod.Radial360;
            _image.SetNativeSize();
        }
    }
}
