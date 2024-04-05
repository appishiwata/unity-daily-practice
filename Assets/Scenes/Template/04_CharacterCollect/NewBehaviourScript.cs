using UnityEngine;

namespace Scenes.Template._04_CharacterCollect
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] CharactersData _charactersData;
        [SerializeField] CharacterCell _characterCellPrefab;
        [SerializeField] Transform _characterList;
        
        void Start()
        {
            // キャラクター一覧を表示
            foreach (var character in _charactersData.characters)
            {
                var characterCell = Instantiate(_characterCellPrefab, _characterList);
                characterCell.SetCharacter(character);
            }
        }
    }
}
