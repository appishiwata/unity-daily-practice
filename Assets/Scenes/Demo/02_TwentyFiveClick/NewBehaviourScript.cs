using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Scenes.Demo._02_TwentyFiveClick
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameObject _numberButtonPrefab;
        [SerializeField] Transform _content;

        void Start()
        {
            List<int> numbers = Enumerable.Range(1, 25).OrderBy(_ => Random.value).ToList();
        
            foreach (var number in numbers)
            {
                var numberButton = Instantiate(_numberButtonPrefab, _content).GetComponent<NumberButton>();
                numberButton.SetNumber(number);
            }
        }
    }
}
