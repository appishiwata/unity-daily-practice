using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._02_PopupDialog
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] PopupDialog _popupDialog;
        [SerializeField] Button _button;
        
        void Start()
        {
            _button.OnClickAsObservable().Subscribe(_ =>
            {
                _popupDialog.Show();
            });
        }
    }
}
