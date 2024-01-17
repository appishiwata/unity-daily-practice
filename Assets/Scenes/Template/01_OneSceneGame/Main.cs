using DG.Tweening;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._01_OneSceneGame
{
    public class Main : MonoBehaviour
    {
        [Header("Panel")]
        [SerializeField] GameObject _titlePanel;
        [SerializeField] GameObject _gamePanel;
        
        [Header("CanvasGroup")]
        [SerializeField] Image _fade;

        [Header("Button")]
        [SerializeField] Button _startButton;
        [SerializeField] Button _backButton;
        
        [Header("Sound")]
        [SerializeField] AudioSource _buttonSound;
        [SerializeField] AudioSource _bgmSound;
        
        void Start()
        {
            Debug.Log("Play Count: " + Save.GetPlayCount());
            _bgmSound.Play();
            
            _startButton.OnClickAsObservable().Subscribe(_ =>
            {
                _buttonSound.Play();
                Save.IncrementPlayCount();

                _fade.DOFade(1f, 0.5f)
                    .OnComplete(() =>
                    {
                        _titlePanel.gameObject.SetActive(false);
                        _gamePanel.gameObject.SetActive(true);
                        _fade.DOFade(0f, 0.5f);
                        Save.IncrementPlayCount();
                    });
            });
            
            _backButton.OnClickAsObservable().Subscribe(_ =>
            {
                _buttonSound.Play();
                _fade.DOFade(1f, 0.5f)
                    .OnComplete(() =>
                    {
                        _titlePanel.gameObject.SetActive(true);
                        _gamePanel.gameObject.SetActive(false);
                        _fade.DOFade(0f, 0.5f);
                    });
            });
        }
    }
}
