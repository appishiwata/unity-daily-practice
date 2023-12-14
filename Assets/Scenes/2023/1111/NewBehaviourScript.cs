using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace Scenes._1111
{
    public class NewBehaviourScript : MonoBehaviour
    {
        async void Start()
        {
            Debug.Log("Start");
            
            await RequestHttp();
            
            Debug.Log("End");
        }
        
        private static async Task RequestHttp()
        {
            var client = new HttpClient();
       
            try
            {
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
                response.EnsureSuccessStatusCode();
                await response.Content.ReadAsStringAsync();
                Debug.Log("Status Code: " + response.StatusCode);
            }
            catch(HttpRequestException)
            {
                Debug.Log("\nException Caught!");
            }

            client.Dispose();
        }
    }
}
