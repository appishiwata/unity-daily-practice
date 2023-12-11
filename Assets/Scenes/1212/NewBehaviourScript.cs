using UnityEngine;

namespace Scenes._1212
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Mathfクラス : 数学関数を提供するクラス
            // サンプル
            // Abs : 絶対値を返す
            Debug.Log(Mathf.Abs(-10));
            
            // Acos : アークコサインを返す
            Debug.Log(Mathf.Acos(0.5f));
            
            // Asin : アークサインを返す
            Debug.Log(Mathf.Asin(0.5f));
            
            // Atan : アークタンジェントを返す
            Debug.Log(Mathf.Atan(0.5f));
            
            // Max : 2つの値のうち大きい方を返す
            Debug.Log(Mathf.Max(1, 2));
            
            // Min : 2つの値のうち小さい方を返す
            Debug.Log(Mathf.Min(1, 2));
            
            // Round : 四捨五入した値を返す
            Debug.Log(Mathf.Round(1.5f));
            
            // Floor : 切り捨てた値を返す
            Debug.Log(Mathf.Floor(1.5f));
            
            // Ceil : 切り上げた値を返す
            Debug.Log(Mathf.Ceil(1.5f));
        }
    }
}
