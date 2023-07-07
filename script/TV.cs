using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour
{
    public VideoPlayer video;

    bool isPlaying;

    void OnMouseDown() 
    {
        isPlaying = !isPlaying;


        if(isPlaying)
        {
            video.Play();
        }
        else{
            video.Pause();
        }
    }

}
