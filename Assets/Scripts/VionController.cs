using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VionController : MonoBehaviour
{
    [SerializeField] bool Autopilot = false;

    VionMove movement;
    VionShot shot;
    VionCam cam;

    void Start()
    {
        movement = GetComponent<VionMove>();
        movement.enabled = false;

        shot = GetComponent<VionShot>();
        shot.enabled = false;

        cam = GetComponent<VionCam>();
        cam.enabled = false;

        if (Autopilot == false) EnableControl();
    }

    [ContextMenu("EnableControl")]
    public void EnableControl()
    {
        movement.enabled = true;
        shot.enabled = true;
        cam.enabled = true;


        GetComponentInChildren<Camera>()?.gameObject.SetActive(true);
    }

    [ContextMenu("DisableControl")]
    public void DisableControl()
    {
        movement.enabled = false;
        shot.enabled = false;
        cam.enabled = false;
    }



}
