using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Scenes._1115
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Image _imageSprite;
        [SerializeField] Image _imageResources;
        [SerializeField] Image _imageAddressable;
        [SerializeField] Sprite _sprite;
        
        void Start()
        {
            // 普通にspriteを指定
            _imageSprite.sprite = _sprite;

            // Resources.Loadでspriteを指定 (Unity Editor上でのみ動作)
            _imageResources.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Scenes/1115/sample.png");

            // addressableでspriteを指定
            _imageAddressable.sprite = Addressables.LoadAssetAsync<Sprite>("Assets/Scenes/1115/sample.png").WaitForCompletion();
        }
    }
}
