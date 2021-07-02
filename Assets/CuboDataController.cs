using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuboDataController : MonoBehaviour, IAction
{

    [SerializeField] public int numStand;
    [SerializeField] Text uiText;
    [SerializeField] Controller controller;

    public void Activate()
    {
        uiText.text = controller.data.stand[numStand].title;
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
