using UnityEngine;

namespace Scenes._1029
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // インスタンスの作成と自己紹介の呼び出し
            var newUser = new User("testuser", "test@example.com");
            newUser.Introduce();
        }
    }
    
    // Userクラスの定義
    public class User
    {
        // プロパティ
        private string UserName { get; set; }
        private string Email { get; set; }

        // コンストラクタ
        public User(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }

        // 自己紹介メソッド
        public void Introduce()
        {
            Debug.Log($"Hello, my user name is {UserName} and my email is {Email}.");
        }
    }
}