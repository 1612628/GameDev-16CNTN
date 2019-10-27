using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

using UnityEngine.SceneManagement;


public class StreamVideo : MonoBehaviour
{

    public RawImage trailerImage;

    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
    }

    IEnumerator playVideo()
    {
        
        videoPlayer.Prepare();

        WaitForSeconds waitForSeconds = new WaitForSeconds(1);

        while (!videoPlayer.isPrepared)
        {
            Debug.Log("Preparing Video");
            yield return waitForSeconds;
            break;
        }

        Debug.Log("Done preparing Video");

        trailerImage.texture = videoPlayer.texture;
        videoPlayer.Play();

        Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }

        Debug.Log("Done Playing Video");

        gotoMenu();
    }

    void gotoMenu()
    {
        SceneManager.LoadScene(1);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
