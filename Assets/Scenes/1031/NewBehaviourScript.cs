using DG.Tweening;
using UnityEngine;

namespace Scenes._1031
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Transform _targetTransform;

        void Start()
        {
            // Sequenceの生成
            Sequence sequence = DOTween.Sequence();
        
            // スケールアップ
            sequence.Append(_targetTransform.DOScale(2.0f, 1.0f));
        
            // 移動
            sequence.Append(_targetTransform.DOMove(new Vector3(200, 0, 0), 1.0f).SetRelative());
            
            // スケールダウン
            sequence.Append(_targetTransform.DOScale(1.0f, 1.0f));

            // Sequenceを実行
            sequence.Play();
        }
    }
}
