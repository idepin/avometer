using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimatorController : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Show()
    {
        anim.SetBool("Show", true);
    }

    public void Hide()
    {
        anim.SetBool("Show", false);
    }
}
