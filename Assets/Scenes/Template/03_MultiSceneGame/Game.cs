using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scenes.Template._03_MultiSceneGame
{
    public class Game : MonoBehaviour
    {
        [SerializeField] Button _backButton;
        
        void Start()
        {
            _backButton.OnClickAsObservable().Subscribe(_ =>
            {
                SceneManager.LoadScene("TitleScene");
            }).AddTo(this);
        }
    }
}
