using UniRx;
using UnityEngine;

namespace Scenes._1120
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Subjectの初期化
            var subject = new Subject<string>();

            // オブザーバーの追加
            subject.Subscribe(x => Debug.Log($"Observer 1 received: {x}"));
            subject.Subscribe(x => Debug.Log($"Observer 2 received: {x}"));

            // 通知値の発行
            subject.OnNext("Hello");
            subject.OnNext("World");
        }
    }
}
