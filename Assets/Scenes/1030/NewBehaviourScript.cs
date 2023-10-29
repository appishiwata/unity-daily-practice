using UnityEngine;

namespace Scenes._1030
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Userクラスのインスタンスを作成
            var newUser = new User("testuser", "Skill One");
            newUser.ShowUserInfo();
            
            // Skillクラスのインスタンスを作成
            var newSkill = new Skill("Skill Two");
            newSkill.ShowSkill();
        }
    }
    
    public class Skill
    {
        public string SkillName { get; set; }

        public Skill(string skillName)
        {
            SkillName = skillName;
        }

        public void ShowSkill()
        {
            Debug.Log($"Skill: {SkillName}");
        }
    }

    public class User
    {
        public string Name { get; set; }
        public Skill UserSkill { get; set; }

        public User(string name, string skillName)
        {
            Name = name;
            UserSkill = new Skill(skillName);
        }

        public void ShowUserInfo()
        {
            Debug.Log($"User name is {Name}");
            UserSkill.ShowSkill();
        }
    }
}
