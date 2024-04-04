using UnityEngine;

namespace Scenes.Template._04_CharacterCollect
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] CharactersData _charactersData;
        
        void Start()
        {
            CollectCharacter("001");
            
            // 全キャラ一覧
            foreach (var character in _charactersData.characters)
            {
                Debug.Log(character.name);
                
                if (SaveManager.IsCharacterCollected(character.id))
                {
                    Debug.Log("Character already collected!");
                }
            }
        }

        private void CollectCharacter(string characterId)
        {
            SaveManager.MarkCharacterAsCollected(characterId);
        }
    }
}
