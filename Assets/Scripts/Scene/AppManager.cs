using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public void LoadApp(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
