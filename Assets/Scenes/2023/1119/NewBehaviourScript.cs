using System.Collections.Generic;
using UnityEngine;

namespace Scenes._1119
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // 新しいPlayerInfoオブジェクトを作成
            var player = new PlayerInfo
            {
                name = "John Doe",
                level = 10,
                health = 100.0f
            };

            // オブジェクトをJSON文字列にシリアライズする
            var json = JsonUtility.ToJson(player);
            Debug.Log(json); // {"name":"John Doe","level":10,"health":100.0}

            // JSON文字列をPlayerInfoオブジェクトにデシリアライズする
            var deserializedPlayer = JsonUtility.FromJson<PlayerInfo>(json);
            Debug.Log($"Name: {deserializedPlayer.name}, Level: {deserializedPlayer.level}, Health: {deserializedPlayer.health}");
            
            
            // 配列をJSON文字列にシリアライズする
            var playerList = new PlayerList
            {
                players = new List<PlayerInfo>
                {
                    new() { name = "John Doe", level = 10, health = 100.0f },
                    new() { name = "Jane Doe", level = 20, health = 80.0f },
                    new() { name = "Bob", level = 30, health = 90.0f }
                }
            };
            json = JsonUtility.ToJson(playerList);
            Debug.Log(json); 
        }
        
        [System.Serializable]
        public class PlayerInfo
        {
            public string name;
            public int level;
            public float health;
        }
        
        [System.Serializable]
        public class PlayerList
        {
            public List<PlayerInfo> players;
        }
    }
}
