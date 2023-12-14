using UnityEngine;

namespace Scenes._1209
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Quaternionクラス : 回転を表すクラス
            // サンプル
            Quaternion q1 = Quaternion.Euler(0, 90, 0);
            Quaternion q2 = Quaternion.Euler(0, 180, 0);
            
            Debug.Log(q1);
            Debug.Log(q2);
            
            // Quaternionの変数
            // x, y, z, w でそれぞれの要素にアクセスできる
            Debug.Log(q1.x);
            
            // Quaternionのメソッド
            // eulerAngles : オイラー角を返す
            Debug.Log(q1.eulerAngles);
            
            // Quaternionの静的メソッド
            // Euler : オイラー角からQuaternionを返す
            Debug.Log(Quaternion.Euler(0, 90, 0));
        }
    }
}
