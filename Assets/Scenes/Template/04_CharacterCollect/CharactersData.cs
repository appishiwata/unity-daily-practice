using UnityEngine;

namespace Scenes.Template._04_CharacterCollect
{
    [CreateAssetMenu(fileName = "CharactersData", menuName = "ScriptableObjects/CharactersData")]
    public class CharactersData : ScriptableObject
    {
        // Characterクラスを定義
        [System.Serializable]
        public class Character
        {
            public string id;
            public string name;
        }

        public Character[] characters;
    }
}