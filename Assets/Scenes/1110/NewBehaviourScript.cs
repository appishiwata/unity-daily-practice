using System.Threading.Tasks;
using UnityEngine;

namespace Scenes._1110
{
    public class NewBehaviourScript : MonoBehaviour
    {
        async void Start()
        {
            await WaitForTwoSecondsAsync();
            
            Debug.Log("Start");
        }

        private async Task WaitForTwoSecondsAsync()
        {
            await Task.Delay(2000);
        }
    }
}
