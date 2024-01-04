using UnityEngine;
using UnityEngine.UI;

namespace Scenes._2024._0104
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] RawImage _rawImage;
        [SerializeField] Texture _texture;
        
        // Start is called before the first frame update
        void Start()
        {
            // RawImageにテクスチャを設定
            _rawImage.texture = _texture;
            
            // RawImageのサイズを変更
            _rawImage.rectTransform.sizeDelta = new Vector2(200, 200);
            
            // RawImageとImageの違い
            // RawImageはテクスチャを直接表示するためのコンポーネント
            // Imageはスプライトを表示するためのコンポーネント
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
