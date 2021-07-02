using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAt : MonoBehaviour
{
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<RectTransform>().Rotate(0, 180f, 0f);
        transform.GetChild(0).GetComponent<CanvasGroup>().alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + mainCam.transform.rotation * Vector3.back, mainCam.transform.rotation * Vector3.up);
    }
}
