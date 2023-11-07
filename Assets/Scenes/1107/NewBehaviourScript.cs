using UnityEngine;

namespace Scenes._1107
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            User.Instance.Id = 1;
            User.Instance.Name = "test";
            User.Instance.Age = 20;
            User.Instance.DebugLog();
        }
    }
    
    public class User
    {
        public int Id;
        public string Name;
        public int Age;

        public static User Instance { get; } = new();

        public void DebugLog()
        {
            Debug.Log($"User: {Id}, {Name}, {Age}");
        }
    }
}
