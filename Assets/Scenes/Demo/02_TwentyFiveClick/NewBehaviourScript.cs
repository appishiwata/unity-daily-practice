using UnityEngine;

namespace Scenes.Demo._02_TwentyFiveClick
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameObject _numberButtonPrefab;
        [SerializeField] Transform _content;
        
        void Start()
        {
            for (var i = 1; i <= 25; i++)
            {
                var numberButton = Instantiate(_numberButtonPrefab, _content).GetComponent<NumberButton>();
                numberButton.SetNumber(i);
            }
        }
    }
}
