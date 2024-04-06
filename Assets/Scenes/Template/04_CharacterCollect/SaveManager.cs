using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Scenes.Template._04_CharacterCollect
{
    public class SaveManager
    {
        private const string CharacterDataKey = "CharacterData";

        [System.Serializable]
        public class CharacterData
        {
            public List<CharacterState> characterStates = new List<CharacterState>();
        }
        
        [System.Serializable]
        public class CharacterState
        {
            public string id;
            public bool collected;
        }

        private CharacterData _characterData;
        
        // Singleton instance
        private static SaveManager _instance;
        public static SaveManager Instance => _instance ??= new SaveManager();
    
        private SaveManager()
        {
            LoadCharacterData();
        }

        private void SaveCharacterData()
        {
            string jsonData = JsonUtility.ToJson(_characterData);
            PlayerPrefs.SetString(CharacterDataKey, jsonData);
            PlayerPrefs.Save();
        }

        private void LoadCharacterData()
        {
            string jsonData = PlayerPrefs.GetString(CharacterDataKey, "");
            if (!string.IsNullOrEmpty(jsonData))
            {
                _characterData = JsonUtility.FromJson<CharacterData>(jsonData);
            }
            else
            {
                _characterData = new CharacterData();
            }
        }

        public bool IsCharacterCollected(string id) 
        {
            CharacterState characterState = GetCharacterState(id);
            return characterState != null && characterState.collected;
        }

        public void MarkCharacterAsCollected(string id)
        {
            CharacterState characterState = GetCharacterState(id);
            if (characterState == null)
            {
                characterState = new CharacterState { id = id, collected = false };
                _characterData.characterStates.Add(characterState);
            }

            characterState.collected = true;
            SaveCharacterData();
        }

        private CharacterState GetCharacterState(string id)
        {
            return _characterData.characterStates.FirstOrDefault(state => state.id == id);
        }
    }
}