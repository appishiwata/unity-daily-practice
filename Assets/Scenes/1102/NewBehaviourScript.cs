using UnityEngine;

namespace Scenes._1102
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameData _gameData;
        
        void Start()
        {
            Debug.Log($"Player Name: {_gameData.playerName}, Score: {_gameData.score}");
        }
    }
    
    [CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData")]
    public class GameData : ScriptableObject
    {
        public int score;
        public string playerName;
    }
}