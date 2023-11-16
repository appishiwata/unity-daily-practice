using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Scenes._1116
{
    public class NewBehaviourScript : MonoBehaviour
    {
        async void Start()
        {
            await RunAsync();
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
