using System;
using DG.Tweening;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._03_MultiSceneGame
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance = null;
        
        [Header("Fade")]
        [SerializeField] Image _fade;
        
        [Header("PopupDialog")]
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
        
        public void ShowPopup(string message, Action okAction, Action cancelAction)
        {
            _messageText.text = message;
            _popupDialog.SetActive(true);
            _okAction = okAction;
            _cancelAction = cancelAction;
            
            _cancelButton.gameObject.SetActive(cancelAction != null);
        }

        
        
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                if (this != Instance)
                {
                    Destroy(this.gameObject);
                }
            }
        }
        
        public void ShowFade(Action onComplete)
        {
            _fade.DOFade(1f, 0.5f)
                .OnComplete(() =>
                {
                    onComplete();
                    _fade.DOFade(0f, 0.5f);
                });
        }
    }
}
