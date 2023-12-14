using UnityEngine;

namespace Scenes._1029
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // インスタンスの作成と自己紹介の呼び出し
            var newUser = new User("testuser", "test@example.com", User.UserType.Admin);
            newUser.Introduce();
        }
    }
    
    // Userクラスの定義
    public class User
    {
        public enum UserType {
            Admin,
            General,
            Guest
        }
        
        // プロパティ
        private string UserName { get; set; }
        private string Email { get; set; }
        private UserType Type { get; set; } // UserTypeを利用したプロパティ

        // コンストラクタ
        public User(string userName, string email, UserType type = UserType.General)
        {
            UserName = userName;
            Email = email;
            Type = type;
        }

        // 自己紹介メソッド
        public void Introduce()
        {
            Debug.Log($"Hello, my user name is {UserName} and I am a {Type} user.");
        }
    }
}