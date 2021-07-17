using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour
{
    public void Rotate(float add)
    {
        LeanTween.rotate(gameObject, new Vector3(0, add, 0), 1f).setEasePunch();
    }

}
