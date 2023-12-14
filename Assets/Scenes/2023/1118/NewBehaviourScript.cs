using System.Collections.Generic;
using UnityEngine;

namespace Scenes._1118
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            var dict = new Dictionary<string, int>
            {
                {"apple", 10},
                {"banana", 20},
                {"cherry", 30}
            };

            // キーを使って値を取得
            Debug.Log(dict["apple"]);  // Output: 10

            // 新しいキーと値を追加
            dict["durian"] = 40;

            // ディクショナリー内のすべてのキーと値を表示
            foreach (var pair in dict)
            {
                Debug.Log($"Key: {pair.Key}, Value: {pair.Value}");
            }

            // 特定のキーが含まれているか確認
            if (dict.ContainsKey("banana"))
            {
                Debug.Log("Dictionary contains key 'banana'");
            }

            // キーを使ってディクショナリーから要素を削除
            dict.Remove("apple");
        }
    }
}
