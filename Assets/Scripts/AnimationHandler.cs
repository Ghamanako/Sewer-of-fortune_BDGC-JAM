using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ToogleBool(string boolname)
    {
        animator.SetBool(boolname, !animator.GetBool(boolname));
    }
}
