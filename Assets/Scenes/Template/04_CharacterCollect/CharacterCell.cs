using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._04_CharacterCollect
{
    public class CharacterCell : MonoBehaviour
    {
        private CharactersData.Character _character;
        [SerializeField] TextMeshProUGUI _textName;
        [SerializeField] Button _buttonCollect;
        
        void Start()
        {
            _textName.text = _character.name;

            _buttonCollect.OnClickAsObservable()
                .Subscribe(_ =>
                {
                    SaveManager.MarkCharacterAsCollected(_character.id);
                    _buttonCollect.interactable = false;
                }).AddTo(this);
            
            if (SaveManager.IsCharacterCollected(_character.id))
            {
                _buttonCollect.interactable = false;
            }
        }
        
        public void SetCharacter(CharactersData.Character character)
        {
            _character = character;
        }
    }
}
