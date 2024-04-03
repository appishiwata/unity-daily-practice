using UnityEngine;

namespace Scenes.Template._04_CharacterCollect
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] CharactersData _charactersData;
        
        void Start()
        {
            // 全キャラ一覧
            foreach (var character in _charactersData.characters)
            {
                Debug.Log(character.name);
            }
        }
    }
}
