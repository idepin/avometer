using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorController : MonoBehaviour
{
    public static SelectorController instance;

    private void Awake()
    {
        instance = this;
    }
}
