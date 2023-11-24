using UnityEngine;

namespace Scenes._1125
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
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
        }
    }
}
