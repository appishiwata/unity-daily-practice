using DG.Tweening;
using UnityEngine;

namespace Scenes.Demo._01_GachaBanGDream
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] CanvasGroup _cutinGroup;
        
        async void Start()
        {
            PlayAnimation();
        }

        void PlayAnimation()
        {
            _cutinGroup.DOFade(1, 0f).SetDelay(1f);
        }
    }
}
