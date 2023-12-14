using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace Scenes._1116
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private readonly float LongPressTime = 2.0f;
        private float pressTime = 0;
        
        async void Start()
        {
            await RunAsync();
            
            var isPressed = false;

            Observable.EveryUpdate()
                .Where(_ => Input.GetMouseButton(0))
                .Subscribe(_ => {
                    isPressed = true;
                    pressTime += Time.deltaTime;
                
                    if (pressTime >= LongPressTime)
                    {
                        Debug.Log("Long Press Detected!");
                        pressTime = 0;
                    }
                });
        
            Observable.EveryUpdate()
                .Where(_ => Input.GetMouseButtonUp(0))
                .Subscribe(_ => {
                    if (isPressed)
                    {
                        isPressed = false;
                        pressTime = 0;
                    }
                });
        }
        
        private async UniTask RunAsync()
        {
            Debug.Log("Start");

            // 時間をかける処理
            await UniTask.Delay(1000);

            Debug.Log("End");
        }
    }
}
