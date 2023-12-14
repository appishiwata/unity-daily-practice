using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace Scenes._1113
{
    public class NewBehaviourScript : MonoBehaviour
    {
        async void Start()
        {
            var userList = await GetUserListFromHttp();
            userList.users
                .Take(5)
                .ToList()
                .ForEach(user =>
                {
                    Debug.Log(user.id + " " + user.title);
                });
        }
        
        private static async Task<UserList> GetUserListFromHttp()
        {
            var client = new HttpClient();
            var userList = new UserList();
            try
            {
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                Debug.Log("Status Code: " + response.StatusCode);
                userList = JsonUtility.FromJson<UserList>("{\"users\":" + responseBody + "}");
            }
            catch(HttpRequestException)
            {
                Debug.Log("\nException Caught!");
            }

            client.Dispose();
            return userList;
        }
    }
    
    [System.Serializable]
    public class User
    {
        public int id;
        public string title;
    }
    
    [System.Serializable]
    public class UserList
    {
        public List<User> users;
    }
}
