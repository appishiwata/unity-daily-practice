using UnityEngine;

namespace Scenes._1104
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Userクラスのインスタンスを作成
            var newUser = new User(User.UserType.General);
            Debug.Log($"User Type: {newUser.Type}");
        }
    }
    
    public class User
    {
        // 列挙型の定義
        public enum UserType
        {
            Admin,
            General,
            Guest
        }
        public UserType Type { get; set; }
        
        // コンストラクタ
        public User(UserType type)
        {
            Type = type;
        }
    }
}
