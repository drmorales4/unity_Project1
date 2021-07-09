using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CuboDataController : MonoBehaviour, IAction
{

    [SerializeField] public int numStand;
    [SerializeField] Text uiText;
    [SerializeField] Controller controller;
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] GameObject btnVideo;

    public void Activate()
    {
        uiText.text = controller.data.stand[numStand].title;


        if (!controller.data.stand[numStand].video.Equals(""))
        {
            videoPlayer.url = controller.data.stand[numStand].video;
            btnVideo.SetActive(true);
        }
        else
        {
            btnVideo.SetActive(false);
        }
        
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
