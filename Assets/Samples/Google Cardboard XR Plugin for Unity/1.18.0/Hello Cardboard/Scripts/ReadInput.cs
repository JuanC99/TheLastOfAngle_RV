using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    private TextMeshProUGUI texto;
    void Start()
    {
        texto = this.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        System.Array values = System.Enum.GetValues(typeof(KeyCode));
        foreach (KeyCode code in values)
        {
            if (Input.GetKeyDown(code)) { texto.text = (System.Enum.GetName(typeof(KeyCode), code)); }
        }
    }
}
