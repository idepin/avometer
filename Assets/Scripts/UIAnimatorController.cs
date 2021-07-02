using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIAnimatorController : MonoBehaviour
{
    Animator anim;
    public UnityEvent onShow, onHide;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Show()
    {
        anim.SetBool("Show", true);
        onShow.Invoke();
    }

    public void Hide()
    {
        anim.SetBool("Show", false);
        onHide.Invoke();
    }
}
