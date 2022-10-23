using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class interactTrigger : MonoBehaviour
{
    public Animator animator;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            animator.SetBool("Open", true);
        }
    }
}
