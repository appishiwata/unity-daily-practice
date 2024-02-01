using TMPro;
using UnityEngine;

namespace Scenes.Demo._02_TwentyFiveClick
{
    public class TimerManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _timerText;
        private float _startTime;
        private bool _isRunning = true;

        void Start()
        {
            _startTime = Time.time;
        }

        void Update()
        {
            if (!_isRunning) return;
            
            float t = Time.time - _startTime;
            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            _timerText.text = minutes + ":" + seconds;
        }
        
        public void StopTimer()
        {
            _isRunning = false;
        }
        
        public string GetTime()
        {
            return _timerText.text;
        }
    }
}