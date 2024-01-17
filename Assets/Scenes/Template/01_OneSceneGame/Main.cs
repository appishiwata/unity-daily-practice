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
                _titlePanel.SetActive(false);
                _gamePanel.SetActive(true);
                Save.IncrementPlayCount();
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
