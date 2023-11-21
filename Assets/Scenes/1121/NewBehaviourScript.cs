using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._1121
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // Subjectのインスタンスを作成
        private Subject<Unit> _buttonOnClickSubject = new Subject<Unit>();

        // Buttonの参照
        public Button _exampleButton;
        
        void Start()
        {
            // ボタンクリック時にSubjectに通知
            _exampleButton.onClick.AddListener(() => { _buttonOnClickSubject.OnNext(Unit.Default); });

            // Subjectの購読
            _buttonOnClickSubject.Subscribe(_ =>
            {
                Debug.Log("Button was clicked!");
            });
        }
    }
}
