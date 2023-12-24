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
