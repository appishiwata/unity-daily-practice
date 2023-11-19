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
        }
        
        [System.Serializable]
        public class PlayerInfo
        {
            public string name;
            public int level;
            public float health;
        }
    }
}
