using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{

    void Awake()
    {


        Debug.Log("displays connected: " + Display.displays.Length);
        if (Display.displays.Length > 1)
            Display.displays[1].Activate();

        //if (Display.displays.Length > 2)
        //    Display.displays[2].Activate();

        //if (Display.displays.Length > 3)
        //    Display.displays[3].Activate();

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            Screen.fullScreen = !Screen.fullScreen;
            Display.displays[0].SetRenderingResolution(Display.displays[0].systemWidth,
                                           Display.displays[0].systemHeight);

            Display.displays[1].SetRenderingResolution(Display.displays[1].systemWidth,
                                           Display.displays[1].systemHeight);
        }
    }


}
