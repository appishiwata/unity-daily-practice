using System;
using System.IO;
using UnityEngine;

namespace Scenes._1114
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            try
            {
                Debug.Log("Start");
                throw new Exception("An intentional exception has occurred.");
            }
            catch (Exception ex)
            {
                Debug.Log($"Caught an error: {ex.Message}");
            }
            finally
            {
                Debug.Log("Finally");
            }
            
            // テキストファイルを取得する
            var content = GetFileText("Assets/Scenes/1114/TextFile.txt");
            Debug.Log(content);
        }
        
        private string GetFileText(string filePath)
        {
            try 
            {
                string content = File.ReadAllText(filePath);
                return content;
            }
            catch(IOException ex) 
            {
                Debug.Log($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
