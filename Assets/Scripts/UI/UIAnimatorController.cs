using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIAnimatorController : MonoBehaviour
{
    public UnityEvent onShow, onHide;

    [SerializeField]
    float animDuration = 0.4f;

    CanvasGroup cg;

    private void Start()
    {
        cg = GetComponent<CanvasGroup>();
    }

    public void Show()
    {
        LeanTween.alphaCanvas(cg, 1f, animDuration);
        onShow.Invoke();
    }

    public void Hide()
    {
        LeanTween.alphaCanvas(cg, 0f, animDuration);
        onHide.Invoke();
    }
}
