using System;
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
        }
    }
}
