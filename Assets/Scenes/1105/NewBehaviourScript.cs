using UnityEditor;
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
            
            // Resourcesフォルダ内意外の場所にあるScriptableObjectをスクリプトから読み込む
            // Editor上でのみ動作するコード(ビルド時にエラーになるのでビルドするならif文で囲う)
#if UNITY_EDITOR
            var userList = AssetDatabase.LoadAssetAtPath<UserList>("Assets/Scenes/1105/UserList.asset");
            foreach (var user in userList.users)
            {
                Debug.Log($"User Name: {user.name}, User Age: {user.age}");
            }
#endif
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
