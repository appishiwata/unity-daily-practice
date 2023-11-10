using System.Threading.Tasks;
using UnityEngine;

namespace Scenes._1110
{
    public class NewBehaviourScript : MonoBehaviour
    {
        async void Start()
        {
            var task = WaitForTwoSecondsAsync();
            
            Debug.Log("Start");
            
            await task;
            
            Debug.Log("End");
        }

        private async Task WaitForTwoSecondsAsync()
        {
            Debug.Log("WaitForTwoSecondsAsync Start");
            await Task.Delay(2000);
            Debug.Log("WaitForTwoSecondsAsync End");
        }
    }
}
