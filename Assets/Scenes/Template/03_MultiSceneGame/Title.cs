using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scenes.Template._03_MultiSceneGame
{
    public class Title : MonoBehaviour
    {
        [SerializeField] Button _startButton;
        
        [SerializeField] AudioManager _audioManager;

        void Awake()
        {
            DontDestroyOnLoad(_audioManager);
        }

        void Start()
        {
            _startButton.OnClickAsObservable().Subscribe(_ =>
            {
                AudioManager.Instance.PlayButtonSound();
                SceneManager.LoadScene("GameScene");
            }).AddTo(this);
        }
    }
}
