using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scenes.Template._03_MultiSceneGame
{
    public class Title : MonoBehaviour
    {
        [SerializeField] Button _startButton;
        
        void Start()
        {
            _startButton.OnClickAsObservable().Subscribe(_ =>
            {
                SceneManager.LoadScene("GameScene");
            }).AddTo(this);
        }
    }
}
