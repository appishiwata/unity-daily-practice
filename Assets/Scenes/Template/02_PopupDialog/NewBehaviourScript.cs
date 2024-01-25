using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._02_PopupDialog
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] PopupDialog _popupDialog;
        [SerializeField] Button _button;
        [SerializeField] Button _buttonOnlyOk;
        
        void Start()
        {
            _button.OnClickAsObservable().Subscribe(_ =>
            {
                _popupDialog.Show("Hello World!", () =>
                {
                    Debug.Log("OK");
                }, () =>
                {
                    Debug.Log("Cancel");
                });
            });
            
            _buttonOnlyOk.OnClickAsObservable().Subscribe(_ =>
            {
                _popupDialog.Show("Only OK", () =>
                {
                    Debug.Log("OK");
                }, null);
            });
        }
    }
}
