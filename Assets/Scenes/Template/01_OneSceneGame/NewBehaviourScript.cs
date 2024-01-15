using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._01_OneSceneGame
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [Header("Panel")]
        [SerializeField] GameObject _titlePanel;
        [SerializeField] GameObject _gamePanel;

        [Header("Button")]
        [SerializeField] Button _startButton;
        [SerializeField] Button _backButton;
        
        [Header("Sound")]
        [SerializeField] AudioSource _buttonSound;
        [SerializeField] AudioSource _bgmSound;
        
        void Start()
        {
            _bgmSound.Play();
            
            _startButton.OnClickAsObservable().Subscribe(_ =>
            {
                _buttonSound.Play();
                _titlePanel.SetActive(false);
                _gamePanel.SetActive(true);
            });
            
            _backButton.OnClickAsObservable().Subscribe(_ =>
            {
                _buttonSound.Play();
                _titlePanel.SetActive(true);
                _gamePanel.SetActive(false);
            });
        }
    }
}
