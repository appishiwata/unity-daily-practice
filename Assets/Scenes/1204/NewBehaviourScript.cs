using System.Collections;
using UnityEngine;

namespace Scenes._1204
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(PrintAfterDelay());
        }
        
        IEnumerator PrintAfterDelay()
        {
            yield return new WaitForSeconds(5);
            Debug.Log("Printed after 5 seconds delay!");
        }
    }
}
