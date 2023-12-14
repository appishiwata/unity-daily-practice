using UnityEngine;

namespace Scenes._1129
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            SampleMethod();
            SampleMethodWithArg(10);
            Debug.Log(SampleMethodWithReturn());
            Debug.Log(SampleMethodWithArgAndReturn(10));
        }
        
        // サンプルのメソッド
        public void SampleMethod()
        {
            Debug.Log("SampleMethod");
        }
        
        // 引数ありのサンプルのメソッド
        public void SampleMethodWithArg(int arg)
        {
            Debug.Log("SampleMethodWithArg: " + arg);
        }
        
        // 戻り値ありのサンプルのメソッド
        public int SampleMethodWithReturn()
        {
            return 100;
        }
        
        // 引数あり、戻り値ありのサンプルのメソッド
        public int SampleMethodWithArgAndReturn(int arg)
        {
            return arg * 2;
        }
    }
}
