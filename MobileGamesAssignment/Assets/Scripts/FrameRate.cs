using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FrameRate : MonoBehaviour
{

    public TextMeshProUGUI FPStext;

    private float pollingtime = 1f;
    private float time;
    private int frameCount;

    void Start()
    {

        Application.targetFrameRate = 60;

    }

    void Update()
    {

        time += Time.deltaTime;

        frameCount++;

        if(time>=pollingtime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FPStext.text = frameRate.ToString() + " FPS";

            time -= pollingtime;

            frameCount = 0;
        }

    }


}
