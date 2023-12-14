using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Scenes._1028
{
    public class Sample : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        async void Start()
        {
            var str = "Hello World1";
            _text.text = "";
            await _text.DOText(str, 1.0f);

            await UniTask.Delay(1000);
            
            str = "Hello World2";
            _text.text = "";
            await _text.DOText(str, 1.0f);
        }
    }
}
