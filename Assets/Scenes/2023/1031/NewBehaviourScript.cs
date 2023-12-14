using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Scenes._1031
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Transform _targetTransform;

        void Start()
        {
            // どちらでも同じ OnComplete多用より良い
            //AnimationSequence();
            //AnimationAsync();
        }

        async void AnimationAsync()
        {
            await _targetTransform.DOScale(2.0f, 1.0f);
            await _targetTransform.DOMove(new Vector3(200, 0, 0), 1.0f).SetRelative();
            await _targetTransform.DOScale(1.0f, 1.0f);
        }

        void AnimationSequence()
        {
            Sequence sequence = DOTween.Sequence();
            sequence.Append(_targetTransform.DOScale(2.0f, 1.0f));
            sequence.Append(_targetTransform.DOMove(new Vector3(200, 0, 0), 1.0f).SetRelative());
            sequence.Append(_targetTransform.DOScale(1.0f, 1.0f));
            sequence.Play();
        }
    }
}
