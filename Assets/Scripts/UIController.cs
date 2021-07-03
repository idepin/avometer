using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject[] ui;
    int index;
    public GameObject btnDone, btnNext;

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
            if(index == ui.Length - 1)
            {
                btnDone.SetActive(true);
                btnNext.SetActive(false);
            }
            else
            {
                index += 1;
            }

        }
        
    }

    public void Done()
    {
        ui[index].GetComponent<UIAnimatorController>().Hide();
        btnDone.SetActive(false);
        //Selesai
    }
}
