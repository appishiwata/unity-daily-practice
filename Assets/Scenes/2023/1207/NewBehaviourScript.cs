using UnityEngine;

namespace Scenes._1207
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Vector3クラス : 3次元ベクトルを表すクラス
            // サンプル
            Vector3 v1 = new Vector3(1, 2, 3);
            Vector3 v2 = new Vector3(4, 5, 6);
            Vector3 v3 = v1 + v2;
            Vector3 v4 = v1 - v2;
            Vector3 v5 = v1 * 2;
            Vector3 v6 = v1 / 2;
            
            Debug.Log(v1);
            Debug.Log(v2);
            Debug.Log(v3);
            Debug.Log(v4);
            Debug.Log(v5);
            Debug.Log(v6);
            
            // Vector3の変数
            // x, y, z でそれぞれの要素にアクセスできる
            Debug.Log(v1.x);
            
            // Vector3のメソッド
            // magnitude : ベクトルの長さを返す
            Debug.Log(v1.magnitude);
            
            // normalized : ベクトルの正規化したベクトルを返す
            Debug.Log(v1.normalized);
            
            // Vector3の静的メソッド
            // Dot : 2つのベクトルの内積を返す
            Debug.Log(Vector3.Dot(v1, v2));
        }
    }
}
