﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PortShower : MonoBehaviour
{
    public TMPro.TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh.text = "Undefined";
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetPortShowing(int number)
    {
        textMesh.text = $"COM{number}";
    }
}