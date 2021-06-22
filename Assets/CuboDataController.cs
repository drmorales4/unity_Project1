﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuboDataController : MonoBehaviour, IAction
{

    [SerializeField] string textoTitulo;
    [SerializeField] Text uiText;

    public void Activate()
    {
        uiText.text = textoTitulo;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
