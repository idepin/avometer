using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class SimulationItem 
{
    public GameObject textUI;
    public UnityEvent onStart, onEnd;
}