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
        
        void Start()
        {
            _button.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log(_number);
            });
        }
        
        public void SetNumber(int number)
        {
            _number = number;
            _numberText.text = number.ToString();
        }
    }
}
