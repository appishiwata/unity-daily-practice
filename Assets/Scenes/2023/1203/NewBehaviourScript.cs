using UnityEngine;

namespace Scenes._1203
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // MonoBehaviourクラスの関数
        
        void Start()
        {
            Debug.Log("Game started!");
        }

        void Update()
        {
            //Debug.Log("Frame updated!");
        }

        void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collision detected!");
        }
        
        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger detected!");
        }
        
        void OnMouseDown()
        {
            Debug.Log("Mouse clicked!");
        }
        
        void OnMouseEnter()
        {
            Debug.Log("Mouse entered!");
        }
        
        void OnMouseExit()
        {
            Debug.Log("Mouse exited!");
        }
        
        void OnMouseOver()
        {
            Debug.Log("Mouse overed!");
        }
        
        void OnMouseUp()
        {
            Debug.Log("Mouse released!");
        }
        
        void OnMouseUpAsButton()
        {
            Debug.Log("Mouse released as button!");
        }
    }
}
