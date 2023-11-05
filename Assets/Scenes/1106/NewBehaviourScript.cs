using UnityEngine;

namespace Scenes._1106
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
        
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
        }
    }
}
