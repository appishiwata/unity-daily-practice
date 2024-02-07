using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scenes.Template._03_MultiSceneGame
{
    public class Title : MonoBehaviour
    {
        [SerializeField] Button _startButton;
        
        [Header("DontDestroyOnLoad")]
        [SerializeField] AudioManager _audioManager;
        [SerializeField] AnimationManager _animationManager;

        void Awake()
        {
            DontDestroyOnLoad(_audioManager);
            
            // これがうまくいかない。AnimationManager._fadeがCanvas内にある為。
            // 対応策: CanvasもDontDestroyOnLoadする必要がある。
            // Canvasを新たに作成してその中に_fadeを入れる。そしてAnimationManagerをアタッチしてそれごとDontDestroyOnLoadする。
            DontDestroyOnLoad(_animationManager);
        }

        void Start()
        {
            _startButton.OnClickAsObservable().Subscribe(_ =>
            {
                AudioManager.Instance.PlayButtonSound();
                AnimationManager.Instance.ShowFade(() =>
                {
                    SceneManager.LoadScene("GameScene");
                });
            }).AddTo(this);
        }
    }
}
