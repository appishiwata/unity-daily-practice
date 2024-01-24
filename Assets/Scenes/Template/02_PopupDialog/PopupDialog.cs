using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._02_PopupDialog
{
    public class PopupDialog : MonoBehaviour
    {
        [SerializeField] GameObject _popupDialog;
        [SerializeField] TextMeshProUGUI _messageText;
        [SerializeField] Button _closeButton;
        
        void Start()
        {
            _closeButton.OnClickAsObservable().Subscribe(_ =>
            {
                _popupDialog.SetActive(false);
            }).AddTo(this);
        }
        
        public void Show(string message)
        {
            _messageText.text = message;
            _popupDialog.SetActive(true);
        }
    }
}