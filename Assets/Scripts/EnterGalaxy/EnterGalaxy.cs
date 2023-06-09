﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EnterGalaxy : MonoBehaviour
{

    public VideoPlayer videoPlayer;

    void Start() 
    { 
        videoPlayer.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(2);
    }
}
