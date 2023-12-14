using System.Collections.Generic;
using UnityEngine;

namespace Scenes._1112
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            string json = "[{ \"userId\": 1, \"title\": \"delectus aut autem\" }]";
            var  userList = JsonUtility.FromJson<UserList>("{\"users\":" + json + "}");
            Debug.Log(userList.users[0].userId);
            Debug.Log(userList.users[0].title);
        }
    }
    
    [System.Serializable]
    public class User
    {
        public int userId;
        public string title;
    }
    
    [System.Serializable]
    public class UserList
    {
        public List<User> users;
    }
}