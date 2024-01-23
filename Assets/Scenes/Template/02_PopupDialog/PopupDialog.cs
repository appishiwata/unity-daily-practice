using TMPro;
using UnityEngine;

namespace Scenes.Template._02_PopupDialog
{
    public class PopupDialog : MonoBehaviour
    {
        [SerializeField] GameObject _popupDialog;
        [SerializeField] TextMeshProUGUI _messageText;
        
        public void Show(string message)
        {
            _messageText.text = message;
            _popupDialog.SetActive(true);
        }
    }
}