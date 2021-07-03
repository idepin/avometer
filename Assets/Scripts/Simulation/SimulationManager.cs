using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    [SerializeField]
    int tutorialIndex;

    public SimulationItem[] simulationItems;

    private void Start()
    {
        foreach (SimulationItem s in simulationItems)
        {
            s.onStart.AddListener(s.textUI.GetComponentInChildren<UIAnimatorController>().Show);
            s.onEnd.AddListener(s.textUI.GetComponentInChildren<UIAnimatorController>().Hide);
        }
    }
    public void Next()
    {

        if(tutorialIndex < simulationItems.Length)
        {
            if(tutorialIndex != 0)
            {
                simulationItems[tutorialIndex-1].onEnd.Invoke();
            }
            simulationItems[tutorialIndex].onStart.Invoke();
            tutorialIndex++;
        }
    }
}
