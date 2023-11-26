using UnityEngine;

namespace Scenes._1127
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // 制御構文のサンプル
            int a = 10;
            if (a > 5)
            {
                Debug.Log("a is greater than 5");
            }
            else
            {
                Debug.Log("a is less than or equal to 5");
            }
            
            // ループのサンプル
            for (int i = 0; i < 5; i++)
            {
                Debug.LogFormat("i: {0}", i);
            }
            
            // switch文のサンプル
            int b = 2;
            switch (b)
            {
                case 1:
                    Debug.Log("b is 1");
                    break;
                case 2:
                    Debug.Log("b is 2");
                    break;
                default:
                    Debug.Log("b is neither 1 nor 2");
                    break;
            }
            
            // while文のサンプル
            int c = 0;
            while (c < 5)
            {
                Debug.LogFormat("c: {0}", c);
                c++;
            }
            
            // do-while文のサンプル
            int d = 0;
            do
            {
                Debug.LogFormat("d: {0}", d);
                d++;
            } while (d < 5);
            
            // break文のサンプル
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Debug.LogFormat("i: {0}", i);
            }
            
            // continue文のサンプル
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Debug.LogFormat("i: {0}", i);
            }
        }
    }
}
