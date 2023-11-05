using UnityEngine;

namespace Scenes._1105
{
    public class NewBehaviourScript : MonoBehaviour
    {
        public UserList _userList;
        
        void Start()
        {
            foreach (var user in _userList.users)
            {
                Debug.Log($"User Name: {user.name}, User Age: {user.age}");
            }
        }
        
        // ユーザーデータを持つクラス
        [System.Serializable]
        public class User {
            public string name;
            public int age;
        }

        // ScriptableObjectを継承したUserListクラス
        [CreateAssetMenu(fileName = "UserList", menuName = "ScriptableObjects/UserList")]
        public class UserList : ScriptableObject {
            public User[] users;
        }
    }
}
