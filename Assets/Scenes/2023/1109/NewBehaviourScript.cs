using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._1109
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] ScrollRect _scrollRect;
        
        void Start()
        {
            _scrollRect.normalizedPosition = new Vector2(0, 0f);

            DOVirtual.Float(0f, 1f, 10f, value =>
            {
                _scrollRect.normalizedPosition = new Vector2(0f, value);
            });
        }
    }
}
