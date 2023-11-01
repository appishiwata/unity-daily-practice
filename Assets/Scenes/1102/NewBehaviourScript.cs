using UnityEngine;

namespace Scenes._1102
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameData _gameData;
        
        void Start()
        {
            // 初期化
            _gameData.Initialize();
            Debug.Log($"Player Name: {_gameData.playerName}, Score: {_gameData.score}");
            
            // 値の更新 (ゲーム終了後も値は保持される)
            _gameData.score = 100;
            Debug.Log($"Player Name: {_gameData.playerName}, Score: {_gameData.score}");
        }
    }
    
    [CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData")]
    public class GameData : ScriptableObject
    {
        public int score;
        public string playerName;
        
        public void Initialize()
        {
            score = 0;
            playerName = "PlayerDefault";
        }
    }
}