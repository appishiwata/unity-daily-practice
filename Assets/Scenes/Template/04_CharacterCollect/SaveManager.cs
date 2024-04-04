using UnityEngine;

namespace Scenes.Template._04_CharacterCollect
{
    public static class SaveManager
    {
        public static void MarkCharacterAsCollected(string characterId) // set character as collected
        {
            PlayerPrefs.SetInt(characterId, 1);
        }

        public static bool IsCharacterCollected(string characterId) // check if character is collected
        {
            return PlayerPrefs.GetInt(characterId, 0) == 1;
        }
    }
}