using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScaler : MonoBehaviour
{
    [SerializeField]
    float zoomMultiplier = 1f;

    private void Update()
    {
        var dist = Vector3.Distance(transform.position, Camera.main.transform.position);
        transform.localScale = Vector3.one * dist * zoomMultiplier;
    }
}
