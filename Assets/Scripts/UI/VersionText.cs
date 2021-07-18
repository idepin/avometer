using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VersionText : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.SetText("v." + Application.version);
    }
}
