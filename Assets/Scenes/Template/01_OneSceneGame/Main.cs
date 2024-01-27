using DG.Tweening;
using Scenes.Template._02_PopupDialog;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._01_OneSceneGame
{
    public class Main : MonoBehaviour
    {
        [Header("TitlePanel")]
        [SerializeField] GameObject _titlePanel;
        [SerializeField] Button _startButton;
        [SerializeField] Button _resetButton;
        [SerializeField] TextMeshProUGUI _playCountText;

        [Header("GamePanel")]
        [SerializeField] GameObject _gamePanel;
        [SerializeField] Button _backButton;
        
        [Header("Animation")]
        [SerializeField] Image _fade;
        
        [Header("Sound")]
        [SerializeField] AudioSource _buttonSound;
        [SerializeField] AudioSource _bgmSound;
        
        [Header("Other")]
        [SerializeField] PopupDialog _popupDialog;
        
        void Start()
        {
            InitTitlePanel();
            _bgmSound.Play();

            _startButton.OnClickAsObservable().ThrottleFirst(System.TimeSpan.FromSeconds(1)).Subscribe(_ =>
            {
                _buttonSound.Play();
                Save.IncrementPlayCount();

                _fade.DOFade(1f, 0.5f)
                    .OnComplete(() =>
                    {
                        _titlePanel.gameObject.SetActive(false);
                        _gamePanel.gameObject.SetActive(true);
                        _fade.DOFade(0f, 0.5f);
                    });
            }).AddTo(this);
            
            _backButton.OnClickAsObservable().ThrottleFirst(System.TimeSpan.FromSeconds(1)).Subscribe(_ =>
            {
                _buttonSound.Play();
                _fade.DOFade(1f, 0.5f)
                    .OnComplete(() =>
                    {
                        _titlePanel.gameObject.SetActive(true);
                        _gamePanel.gameObject.SetActive(false);
                        InitTitlePanel();
                        _fade.DOFade(0f, 0.5f);
                    });
            }).AddTo(this);
            
            _resetButton.OnClickAsObservable().ThrottleFirst(System.TimeSpan.FromSeconds(1)).Subscribe(_ =>
            {
                _buttonSound.Play();
                _popupDialog.Show("Are you sure you want to reset the play count?", () =>
                {
                    Save.ResetPlayCount();
                    InitTitlePanel();
                }, () =>
                {
                    Debug.Log("Cancel");
                });
            }).AddTo(this);
        }
        
        void InitTitlePanel()
        {
            _playCountText.text = "Play Count: " + Save.GetPlayCount();
        }
    }
}
