using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Scenes._2023._1225
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _text;
        
        // Start is called before the first frame update
        void Start()
        {
            _text.text = "Hello, World!";
            
            // テキストのフォントスタイルを変更
            _text.fontStyle = FontStyles.Bold;
            
            // テキストのアウトラインを有効にする
            _text.enableAutoSizing = true;
            
            // テキストのアウトラインの色を変更
            _text.outlineColor = Color.red;
            
            // テキストのアウトラインの幅を変更
            _text.outlineWidth = 0.2f;
            
            // 真ん中に揃える
            _text.alignment = TextAlignmentOptions.Center;
            
            // サイズを変更
            _text.fontSize = 30;
            
            // Dotweenを使ってアニメーションを追加
            _text.transform.DOScale(1.5f, 1f).SetEase(Ease.OutBack);
            
            // Dotweenを使ってアニメーションを追加
            _text.transform.DORotate(new Vector3(0, 0, 360), 1f, RotateMode.FastBeyond360).SetEase(Ease.Linear);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}


/*

Thu Jan 4 09:04:10 2024 +0900
   Thu Jan 4 09:14:23 2024 +0900
   Fri Jan 5 08:23:03 2024 +0900
   Fri Jan 5 08:34:10 2024 +0900
   Sat Jan 6 09:12:02 2024 +0900
   Sat Jan 6 09:32:11 2024 +0900
   Sun Jan 7 09:01:01 2024 +0900
   Sun Jan 7 09:14:03 2024 +0900
   Mon Jan 8 08:43:23 2024 +0900
   Mon Jan 8 08:54:12 2024 +0900
   Tue Jan 9 08:10:23 2024 +0900
   Tue Jan 9 08:26:03 2024 +0900
   Wed Jan 10 09:04:30 2024 +0900
   Wed Jan 10 09:21:12 2024 +0900

*/