using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour, IAction
{
    // Start is called before the first frame update
    [SerializeField] GameObject panel;

    [SerializeField] CursorController cursorController;
    

    void Start()
    {
        
        panel.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {

        LeanTween.scale(panel, new Vector3(1, 1, 1), 0.5F);
        cursorController.ActiveCursor();
    }

    public void Desactive()
    {
        LeanTween.scale(panel, new Vector3(0, 0, 0), 0.5F);

        cursorController.DesactiveCursor();
    }
}