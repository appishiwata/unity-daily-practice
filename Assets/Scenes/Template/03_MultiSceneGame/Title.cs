using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scenes.Template._03_MultiSceneGame
{
    public class Title : MonoBehaviour
    {
        [SerializeField] Button _startButton;
        [SerializeField] TextMeshProUGUI _playCountText;
        
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
            InitTitlePanel();
            
            _startButton
                .OnClickAsObservable()
                .ThrottleFirst(System.TimeSpan.FromSeconds(1))
                .Subscribe(_ =>
            {
                AudioManager.Instance.PlayButtonSound();
                SaveManager.IncrementPlayCount();
                AnimationManager.Instance.ShowFade(() =>
                {
                    SceneManager.LoadScene("GameScene");
                });
            }).AddTo(this);
        }
        
        void InitTitlePanel()
        {
            _playCountText.text = "Play Count: " + SaveManager.GetPlayCount();
        }
    }
}
