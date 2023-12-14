using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._1121
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // Subjectのインスタンスを作成
        private Subject<Unit> _buttonOnClickSubject = new();
        private Subject<int> _clickCountSubject = new();
        private int _clickCount;
        private int _clickCountUniRx;
        
        // Buttonの参照
        public Button _exampleButton;
        
        void Start()
        {
            // ボタンクリック時にSubjectに通知
            _exampleButton.onClick.AddListener(() => { _buttonOnClickSubject.OnNext(Unit.Default); });
            _exampleButton.onClick.AddListener(() => { _clickCount++; _clickCountSubject.OnNext(_clickCount); });

            // Subjectの購読
            _buttonOnClickSubject.Subscribe(_ =>
            {
                Debug.Log("Button was clicked!");
            });
            _clickCountSubject.Subscribe(clickCount =>
            {
                Debug.Log("Button was clicked " + clickCount + " times!");
            });
            
            // UniRxでの書き方
            _exampleButton.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Button was clicked! (UniRx)");
            });
            _exampleButton.OnClickAsObservable().Subscribe(_ =>
            {
                _clickCountUniRx++;
                Debug.Log("Button was clicked " + _clickCountUniRx + " times! (UniRx)");
            });
        }
    }
}
