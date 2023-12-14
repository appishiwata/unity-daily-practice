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
            
            // Userクラスの構造体の値を更新
            var newUserUserSkills = newUser.UserSkills;
            Debug.Log($"User Skill ID: {newUserUserSkills.ID}, User Skill Name: {newUserUserSkills.Name}");
            newUserUserSkills.ID = "S2";
            newUserUserSkills.Name = "Skill Two";
            Debug.Log($"User Skill ID: {newUserUserSkills.ID}, User Skill Name: {newUserUserSkills.Name}");
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
        
        // 構造体の定義
        public struct Skills
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
        public Skills UserSkills { get; set; }
        
        // コンストラクタ
        public User(UserType type)
        {
            Type = type;
            UserSkills = new Skills
            {
                ID = "S1",
                Name = "Skill One"
            };
        }
    }
}
