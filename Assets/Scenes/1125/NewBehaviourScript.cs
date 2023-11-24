using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Scenes._1125
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] GameObject _cube;

        async void Start()
        {
            // メッセージを表示
            Debug.Log("Player has entered the trigger zone.");
            
            // 変数を表示
            int playerHealth = 100;
            Debug.Log("Player's health: " + playerHealth);
            
            // 警告メッセージを表示
            Debug.LogError("This is an error message.");
            Debug.LogWarning("This is a warning message.");
            
            // 色付きのメッセージを表示
            Debug.Log("<color=red>Error!</color> Something went wrong.");
            Debug.Log("<color=green>Success:</color> Everything's fine!");
            Debug.Log("<color=blue>Information:</color> I am here.");
            
            // 強調表示
            Debug.Log("<b>Bold text</b> and normal text");
            Debug.Log("<i>Italic text</i> and normal text");
            
            // サイズ変更
            Debug.Log("<size=20>Large Text</size> and normal text");
            
            // 3秒待機
            await UniTask.Delay(3000);
            
            // Editor一時停止
            Debug.Break();
            
            // 第二引数にオブジェクトを指定すると、そのオブジェクトの位置が表示される
            Debug.Log("cubeです", _cube);
            
            // Debug.LogFormatを使って変数を埋め込む
            Debug.LogFormat("Player's health: {0}", playerHealth);
            
            // 複数の変数に対応 3つ
            var playerName = "Player1";
            var playerLevel = 10;
            var playerScore = 1000;
            Debug.LogFormat("Player's name: {0}, level: {1}, score: {2}", playerName, playerLevel, playerScore);
        }
    }
}
