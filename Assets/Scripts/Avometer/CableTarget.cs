using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SplineMesh;

public class CableTarget : MonoBehaviour
{
    public Spline spline;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spline.nodes[1].Position = transform.position;
        spline.nodes[1].Direction = transform.forward;
    }
}
