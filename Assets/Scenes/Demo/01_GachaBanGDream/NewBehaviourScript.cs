using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Demo._01_GachaBanGDream
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] CanvasGroup _cutinGroup;
        [SerializeField] CanvasGroup _textGroup;

        [SerializeField] GameObject _characterObject;
        [SerializeField] Image _characterImage;
        [SerializeField] Image _characterImageHighlight;

        [SerializeField] Image[] _starImages;

        [SerializeField] CanvasGroup _newImage;

        async void Start()
        {
            PlayAnimation();
        }

        void PlayAnimation()
        {
            _cutinGroup.DOFade(1, 0f).SetDelay(1f);
            
            _characterObject.transform.DOLocalMoveX(-380, 0.3f)
                .SetDelay(1f)
                .OnComplete(() =>
                {
                    _characterImage.DOFade(1, 0);
                    _characterImage.transform.DOLocalMoveX(20f, 0.8f).SetRelative();
                    _characterImageHighlight.DOFade(0, 0.8f);
                });
        
            _textGroup.DOFade(1, 0f).SetDelay(1.1f);

            var delay = 1.8f;
            foreach (var starImage in _starImages)
            {
                starImage.transform.DOScale(1.4f, 0f);
                starImage.DOFade(1, 0).SetDelay(delay);
                starImage.transform.DOScale(0.8f, 0.2f)
                    .SetEase(Ease.OutBack)
                    .SetDelay(delay);
                delay += 0.1f;
            }

            _newImage.transform.DOScale(0, 0);
            _newImage.DOFade(1, 0f).SetDelay(2f);
            _newImage.transform.DOScale(0.8f, 0.2f)
                .SetEase(Ease.OutBack)
                .SetDelay(2.2f);
        }
    }
}
