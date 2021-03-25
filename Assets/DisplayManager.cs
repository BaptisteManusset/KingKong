using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{

#if UNITY_STANDALONE_WIN
    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
    [DllImport("user32.dll", EntryPoint = "FindWindow")]
    public static extern IntPtr FindWindow(System.String className, System.String windowName);

    public static void SetPosition(int x, int y, int resX = 0, int resY = 0)
    {
        SetWindowPos(FindWindow(null, "King Kong Vr"), 0, x, y, resX, resY, resX * resY == 0 ? 1 : 0);
    }
#endif
    void Awake()
    {
        SetPosition(0, 0);



        Debug.Log("displays connected: " + Display.displays.Length);
        if (Display.displays.Length > 1)
            Display.displays[1].Activate();

        //if (Display.displays.Length > 2)
        //    Display.displays[2].Activate();

        //if (Display.displays.Length > 3)
        //    Display.displays[3].Activate();

    }



}
