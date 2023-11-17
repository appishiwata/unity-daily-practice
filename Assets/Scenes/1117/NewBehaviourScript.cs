using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._1117
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Image _image;
        [SerializeField] Image _target;
        [SerializeField] Image _middle;

        async void Start()
        {
            var startPoint = _image.transform.position;
            var middlePoint = _middle.transform.position;
            var endPoint = _target.transform.position;
            
            // 通常の移動
            await _image.transform.DOMove(endPoint, 2);
            await _image.transform.DOMove(startPoint, 0);

            // 3地点指定の曲線移動
            Vector3[] path1 = new Vector3[] {
                startPoint,
                middlePoint,
                endPoint
            };
            await _image.transform.DOPath(path1, 1, PathType.CatmullRom);
            await _image.transform.DOMove(startPoint, 0);
            
            // 2地点指定の曲線移動
            Vector3[] path2 = new Vector3[] {
                startPoint,
                (startPoint + endPoint) / 2 + new Vector3(-100f, 100, 0),
                endPoint
            };
            await _image.transform.DOPath(path2, 1, PathType.CatmullRom);
            await _image.transform.DOMove(startPoint, 0);
        }
    }
}
