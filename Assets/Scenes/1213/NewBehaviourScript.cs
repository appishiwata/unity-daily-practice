using UnityEngine;

namespace Scenes._1213
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Rondomクラス : 乱数を生成するクラス
            // サンプル
            // Range : 指定した範囲の乱数を生成する
            Debug.Log(Random.Range(0, 10));
            
            // Randomのメソッド
            // InitState : 乱数のシードを設定する
            Random.InitState(100);
            
            // Randomの変数
            // state : 乱数の状態を取得する
            Debug.Log(Random.state);
            
            // Rotation : 乱数の状態を取得する
            Debug.Log(Random.rotation);
        }
    }
}
