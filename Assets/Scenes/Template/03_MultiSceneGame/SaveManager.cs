using UnityEngine;

namespace Scenes.Template._03_MultiSceneGame
{
    public static class SaveManager
    {
        private const string Key = "PlayCount";

        public static void IncrementPlayCount()
        {
            int currentCount = PlayerPrefs.GetInt(Key, 0);
            PlayerPrefs.SetInt(Key, currentCount + 1);
        }

        public static int GetPlayCount()
        {
            return PlayerPrefs.GetInt(Key, 0);
        }
        
        public static void ResetPlayCount()
        {
            PlayerPrefs.SetInt(Key, 0);
        }
    }
}