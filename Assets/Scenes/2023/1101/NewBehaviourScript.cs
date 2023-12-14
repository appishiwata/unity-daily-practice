using UnityEditor;
using UnityEngine;

namespace Scenes._1101
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private static readonly int ResolutionMultiplier = 1; // 解像度の倍率

        [MenuItem("Tools/Screenshot")]
        public static void Screenshot()
        {
            string filepath = "Assets/Editor/Screenshots";
            filepath += "/screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

            ScreenCapture.CaptureScreenshot(filepath, ResolutionMultiplier);
            Debug.Log("Screenshot taken at: " + filepath);
        }
    }
}
