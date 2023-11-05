using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Scenes._1106
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            var userList = AssetDatabase.LoadAssetAtPath<UserList>("Assets/Scenes/1106/UserList.asset");
            var user = userList.GetUserById(2);
            Debug.Log($"User Name: {user.name}, User Age: {user.age}");
        }
        
        // ユーザーデータを持つクラス
        [System.Serializable]
        public class User
        {
            public int id;
            public string name;
            public int age;
        }

        // ScriptableObjectを継承したUserListクラス
        [CreateAssetMenu(fileName = "UserList", menuName = "ScriptableObjects/UserList")]
        public class UserList : ScriptableObject
        {
            public User[] users;
            
            public User GetUserById(int id)
            {
                return users.FirstOrDefault(user => user.id == id);
            }
        }
    }
}
