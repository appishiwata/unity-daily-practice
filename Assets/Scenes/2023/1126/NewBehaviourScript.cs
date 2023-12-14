using UnityEngine;

namespace Scenes._1126
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // 色々な型の変数を作成
            int playerHealth = 100;
            float playerSpeed = 5.5f;
            string playerName = "Player1";
            bool isPlayerAlive = true;
            Debug.LogFormat("Player's health: {0}, speed: {1}, name: {2}, alive: {3}", playerHealth, playerSpeed, playerName, isPlayerAlive);
            
            // 四則演算のサンプル
            int a = 10;
            int b = 3;
            Debug.LogFormat("a + b = {0}", a + b);
            
            // 比較演算のサンプル
            Debug.LogFormat("a == b: {0}", a == b);
            
            // 論理演算のサンプル
            bool c = true;
            bool d = false;
            Debug.LogFormat("c && d: {0}", c && d);
            
            // 三項演算子のサンプル
            int e = 5;
            int f = 10;
            int max = e > f ? e : f;
            Debug.LogFormat("max: {0}", max);
            
            // インクリメント、デクリメントのサンプル
            int g = 10;
            g++;
            Debug.LogFormat("g: {0}", g);
            
            // 複合代入演算子のサンプル
            int h = 10;
            h += 5;
            Debug.LogFormat("h: {0}", h);
        }
    }
}
