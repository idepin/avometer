using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DrawLine : MonoBehaviour
{
    LineRenderer lineRenderer;
    public Transform target;
    public UIAnimatorController uIAnimatorController;
    bool initialized;
    private void Start()
    {
        uIAnimatorController.onShow.AddListener(Show);
        uIAnimatorController.onHide.AddListener(Hide);
    }

    void Init()
    {
        if (!initialized)
        {
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.startWidth = 0.02f;
            lineRenderer.endWidth = 0.005f;
            
            initialized = true;
        }
    }
    void Show()
    {
        Init();
    }

    void Hide()
    {
        lineRenderer.enabled = false;
    }

    private void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, target.position);
    }
}
