using DG.Tweening;
using UnityEngine;

namespace Scenes._1108
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameObject _move;
        
        void Start()
        {
            _move.transform.DOMoveY(1000, 10f)
                .SetRelative();
        }
    }
}
