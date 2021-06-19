using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject[] ui;
    int index;

    public void Show()
    {
        ui[index].GetComponent<UIAnimatorController>().Show();
        if(index != 0)
        {
            ui[index - 1].GetComponent<UIAnimatorController>().Hide();
        }
    }

    public void Next()
    {
        if(index < ui.Length)
        {
            index += 1;
        }
        
    }
}
