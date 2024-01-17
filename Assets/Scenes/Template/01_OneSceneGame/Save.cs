using UnityEngine;

namespace Scenes.Template._01_OneSceneGame
{
    public static class Save
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
    }
}