using TMPro;
using UnityEngine;

namespace Scenes.Demo._02_TwentyFiveClick
{
    public class TimerManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _timerText;
        private float _startTime;

        void Start()
        {
            _startTime = Time.time;
        }

        void Update()
        {
            float t = Time.time - _startTime;
            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            _timerText.text = minutes + ":" + seconds;
        }
    }
}