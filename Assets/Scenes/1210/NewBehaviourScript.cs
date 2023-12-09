using UnityEngine;

namespace Scenes._1210
{
    public class NewBehaviourScript : MonoBehaviour
    {
        public Enemy enemyData;
        
        void Start()
        {
            // ScriptableObjectクラス : シーンをまたいでデータを保持するクラス

            Debug.Log($"Enemy Name: {enemyData.enemyName}");
            Debug.Log($"Hit Points: {enemyData.hitPoints}");
            Debug.Log($"Speed: {enemyData.speed}");
        }
    }
    
    [CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObjects/Enemy")]
    public class Enemy : ScriptableObject
    {
        public string enemyName;
        public int hitPoints;
        public float speed;
    }
}
