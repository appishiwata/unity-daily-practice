using System.Collections.Generic;
using UnityEngine;

namespace Scenes._1027
{
    public class Sample : MonoBehaviour
    {
        private void Start()
        {
            // Dictionaryで例外が発生するか確認
            UserInfo userInfoWithSkills = new UserInfo
            {
                ID = "U1",
                Name = "User One",
                Level = 10,
                UserSkills = new Skills
                {
                    ID = "S1",
                    Name = "Skill One"
                }
            };

            UserInfo userInfoWithoutSkills = new UserInfo
            {
                ID = "U2",
                Name = "User Two",
                Level = 20,
                UserSkills = null
            };

            Dictionary<string, object> newUserInfo1 = new Dictionary<string, object>()
            {
                {"UserID", userInfoWithSkills.ID},
                {"UserLevel", userInfoWithSkills.Level},
                {"UserSkillID", userInfoWithSkills.UserSkills.ID},
                {"UserSkillName", userInfoWithSkills.UserSkills.Name},
            };

            // しっかり例外が発生する。
            // 例外出ないように対応
            Dictionary<string, object> newUserInfo2 = new Dictionary<string, object>()
            {
                {"UserID", userInfoWithoutSkills.ID},
                {"UserLevel", userInfoWithoutSkills.Level},
                {"UserSkillID", userInfoWithoutSkills.UserSkills?.ID},
                {"UserSkillName", userInfoWithoutSkills.UserSkills?.Name},
            };
        }
    }
    
    public class UserInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Skills UserSkills { get; set; }
    }

    public class Skills
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}

