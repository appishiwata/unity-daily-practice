using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using TMPro;
using UniRx;
using UnityEngine;

namespace Scenes.Demo._02_TwentyFiveClick
{
    public class Main : MonoBehaviour
    {
        [SerializeField] GameObject _numberButtonPrefab;
        [SerializeField] Transform _content;

        [SerializeField] GameObject _clearPanel;
        [SerializeField] TextMeshProUGUI _clearText;
        [SerializeField] TextMeshProUGUI _clearTimeText;
        [SerializeField] TimerManager _timerManager;
        
        private int _currentNumber = 1;
        
        void Start()
        {
            List<int> numbers = Enumerable.Range(1, 25).OrderBy(_ => Random.value).ToList();
        
            foreach (var number in numbers)
            {
                var numberButton = Instantiate(_numberButtonPrefab, _content).GetComponent<NumberButton>();
                numberButton.SetNumber(number);
            }

            // ボタンが押されたら数字をチェックする
            NumberButton.OnClickButton.Subscribe(numberButton =>
            {
                var number = numberButton.GetNumber();
                if (number == _currentNumber)
                {
                    numberButton.DisableButton();
                    _currentNumber++;

                    if (_currentNumber == 6)
                    {
                        GameClear();
                    }
                }
            }).AddTo(this);
        }
        
        private void GameClear()
        {
            _timerManager.StopTimer();
            _clearPanel.SetActive(true);
            _clearText.DOScale(2f, 0.5f);
            _clearTimeText.text = _timerManager.GetTime();
        }
    }
}
