using System.Linq;
using UnityEditor;
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

            // 
            UserDatas.Instance.GetUserById(2).DebugLog();
        }
    }
    
    [System.Serializable] // シリアライズ可能なクラスにする(インスペクター上で値を設定できるようになる)
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
    
    [CreateAssetMenu(fileName = "UserDatas", menuName = "ScriptableObjects/UserDatas")]
    public class UserDatas : ScriptableObject
    {
        public User[] users;
          
        // 普通のクラスのようにインスタンスを作成することはできない
        //public static UserDatas Instance { get; } = new();
        
        // 代わりにScriptableObject.CreateInstanceを使う
        private static UserDatas _instance;
        public static UserDatas Instance => _instance ??= AssetDatabase.LoadAssetAtPath<UserDatas>("Assets/Scenes/1107/UserDatas.asset");
        
        public User GetUserById(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
    }
}
