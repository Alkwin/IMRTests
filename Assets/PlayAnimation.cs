using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("============================== Collided with object" + other.name);
        if(other.CompareTag("Another3DObject"))
        {
            animator.SetBool("Collided", true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("============================== Avoided object" + other.name);
        if (other.CompareTag("Another3DObject"))
        {
            animator.SetBool("Collided", false);
        }
    }
}
