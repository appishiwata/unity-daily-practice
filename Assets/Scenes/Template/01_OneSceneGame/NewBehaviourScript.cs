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
        
        void Start()
        {
            _startButton.OnClickAsObservable().Subscribe(_ =>
            {
                _titlePanel.SetActive(false);
                _gamePanel.SetActive(true);
            });
            
            _backButton.OnClickAsObservable().Subscribe(_ =>
            {
                _titlePanel.SetActive(true);
                _gamePanel.SetActive(false);
            });
        }
    }
}
