using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._02_PopupDialog
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] Button _button;
        
        void Start()
        {
            // uniRxでButtonのクリックイベントを追加
            _button.OnClickAsObservable().Subscribe(_ =>
            {
                // PopupDialogを表示
            });
        }
    }
}
