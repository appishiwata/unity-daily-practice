using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Demo._02_TwentyFiveClick
{ 
    public class NumberButton : MonoBehaviour
    {
        [SerializeField] Button _button;
        [SerializeField] TextMeshProUGUI _numberText;
        private int _number;
        
        public static readonly Subject<NumberButton> OnClickButton = new Subject<NumberButton>();
        
        void Start()
        {
            _button.onClick.AsObservable().Subscribe(_ =>
            {
                OnClickButton.OnNext(this);
            });
        }
        
        public void SetNumber(int number)
        {
            _number = number;
            _numberText.text = number.ToString();
        }
        
        public int GetNumber()
        {
            return _number;
        }

        public void DisableButton()
        {
            _button.interactable = false;
        }
    }
}
