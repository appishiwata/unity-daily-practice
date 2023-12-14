using UniRx;
using UnityEngine;

namespace Scenes._1122
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private Subject<string> _clickSubject = new();
        
        void Start()
        {
            _clickSubject.Subscribe(str =>
            {
                Debug.Log(str);
            });
            
            _clickSubject.OnNext("Message that will be ignored");
            _clickSubject.OnNext("Message that will be ignored 2");
        }
    }
}
