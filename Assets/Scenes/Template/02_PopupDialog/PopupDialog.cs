using System;
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
        [SerializeField] Button _okButton;
        [SerializeField] Button _cancelButton;
        private Action _okAction;
        private Action _cancelAction;
        
        void Start()
        {
            _okButton.OnClickAsObservable().Subscribe(_ =>
            {
                _okAction();
                _popupDialog.SetActive(false);
            }).AddTo(this);

            _cancelButton.OnClickAsObservable().Subscribe(_ =>
            {
                _cancelAction();
                _popupDialog.SetActive(false);
            }).AddTo(this);
        }
        
        public void Show(string message, Action okAction, Action cancelAction)
        {
            _messageText.text = message;
            _popupDialog.SetActive(true);
            _okAction = okAction;
            _cancelAction = cancelAction;
            
            _cancelButton.gameObject.SetActive(cancelAction != null);
        }
    }
}