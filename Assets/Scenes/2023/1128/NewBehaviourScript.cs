using UnityEngine;

namespace Scenes._1128
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // 配列のサンプル
            int[] array = {1, 2, 3, 4, 5};
            for (int i = 0; i < array.Length; i++)
            {
                Debug.LogFormat("array[{0}]: {1}", i, array[i]);
            }
            
            // 配列のサンプル(文字列)
            string[] names = {"Alice", "Bob", "Charlie"};
            for (int i = 0; i < names.Length; i++)
            {
                Debug.LogFormat("names[{0}]: {1}", i, names[i]);
            }
            
            // 特定の要素のインデックスを取得
            int[] array2 = {1, 2, 3, 4, 5};
            Debug.LogFormat("Array.IndexOf(array2, 3): {0}", System.Array.IndexOf(array2, 3));
            
            // 並び替え
            int[] array3 = {3, 1, 5, 4, 2};
            System.Array.Sort(array3);
            for (int i = 0; i < array3.Length; i++)
            {
                Debug.LogFormat("array3[{0}]: {1}", i, array3[i]);
            }
            
            // 並び替え (逆順)
            int[] array4 = {3, 1, 5, 4, 2};
            System.Array.Sort(array4);
            System.Array.Reverse(array4);
            for (int i = 0; i < array4.Length; i++)
            {
                Debug.LogFormat("array4[{0}]: {1}", i, array4[i]);
            }
        }
    }
}
