using UnityEngine;

namespace Scenes._1208
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Vector2クラス : 2次元ベクトルを表すクラス
            // サンプル
            Vector2 v1 = new Vector2(1, 2);
            Vector2 v2 = new Vector2(3, 4);
            Vector2 v3 = v1 + v2;
            Vector2 v4 = v1 - v2;
            Vector2 v5 = v1 * 2;
            Vector2 v6 = v1 / 2;
            
            Debug.Log(v1);
            Debug.Log(v2);
            Debug.Log(v3);
            Debug.Log(v4);
            Debug.Log(v5);
            Debug.Log(v6);
            
            // Vector2の変数
            // x, y でそれぞれの要素にアクセスできる
            Debug.Log(v1.x);
            
            // Vector2のメソッド
            // magnitude : ベクトルの長さを返す
            Debug.Log(v1.magnitude);
            
            // normalized : ベクトルの正規化したベクトルを返す
            Debug.Log(v1.normalized);
            
            // Vector2の静的メソッド
            // Angle : 2つのベクトルの角度を返す
            Debug.Log(Vector2.Angle(v1, v2));
        }
    }
}
