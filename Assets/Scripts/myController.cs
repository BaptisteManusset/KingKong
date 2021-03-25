using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class myController : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    //Rigidbody playerRigidbody;
    public string mybuf;
    public string[] joyname;
    [TextArea] public string history;

    void Start()
    {
        buttonText.text = "Button: nothin yet";
        //playerRigidbody = GetComponent<Rigidbody>();
        mybuf = "";
        joyname = Input.GetJoystickNames();
    }


    void Update()
    {
        // Store the input axes.
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        // Move the player around the scene.
        // Set the movement vector based on the axis input.
        //movement.Set(x, 0f, z);
        // Move the player to it's current position plus the movement.
        //playerRigidbody.MovePosition(transform.position + movement);
        // map the physical joystick buttons to their Unity equivalents
        if (Input.GetKey(KeyCode.JoystickButton0)) mybuf += "JoystickButton0, ";
        if (Input.GetKey(KeyCode.JoystickButton1)) mybuf += "JoystickButton1, ";
        if (Input.GetKey(KeyCode.JoystickButton2)) mybuf += "JoystickButton2, ";
        if (Input.GetKey(KeyCode.JoystickButton3)) mybuf += "JoystickButton3, ";
        if (Input.GetKey(KeyCode.JoystickButton4)) mybuf += "JoystickButton4, ";
        if (Input.GetKey(KeyCode.JoystickButton5)) mybuf += "JoystickButton5, ";
        if (Input.GetKey(KeyCode.JoystickButton6)) mybuf += "JoystickButton6, ";
        if (Input.GetKey(KeyCode.JoystickButton7)) mybuf += "JoystickButton7, ";
        if (Input.GetKey(KeyCode.JoystickButton8)) mybuf += "JoystickButton8, ";
        if (Input.GetKey(KeyCode.JoystickButton9)) mybuf += "JoystickButton9, ";
        if (Input.GetKey(KeyCode.JoystickButton10)) mybuf += "JoystickButton10, ";
        if (Input.GetKey(KeyCode.JoystickButton11)) mybuf += "JoystickButton11, ";
        if (Input.GetKey(KeyCode.JoystickButton12)) mybuf += "JoystickButton12, ";
        if (Input.GetKey(KeyCode.JoystickButton13)) mybuf += "JoystickButton13, ";
        if (Input.GetKey(KeyCode.JoystickButton14)) mybuf += "JoystickButton14, ";
        if (Input.GetKey(KeyCode.JoystickButton15)) mybuf += "JoystickButton15, ";
        if (Input.GetKey(KeyCode.JoystickButton16)) mybuf += "JoystickButton16, ";
        if (Input.GetKey(KeyCode.JoystickButton17)) mybuf += "JoystickButton17, ";
        if (Input.GetKey(KeyCode.JoystickButton18)) mybuf += "JoystickButton18, ";
        if (Input.GetKey(KeyCode.JoystickButton19)) mybuf += "JoystickButton19, ";
        if (Input.GetButton("Fire1")) mybuf += " GetButton('Fire1'), ";  // same as JoystickButton0;
        if (Input.GetButton("Fire2")) mybuf += " GetButton('Fire2'), ";  // same as JoystickButton1;
        if (Input.GetButton("Fire3")) mybuf += " GetButton('Fire3'), ";  // same as JoystickButton2;
        if (Input.GetKeyDown("space")) mybuf += "GetKeyDown('space'), ";
        if (Input.GetKey(KeyCode.Space)) mybuf += "GetKey(KeyCode.Space), ";
        if (mybuf.Length > 0)
        {

            history += mybuf + " (" + joyname[0] + ")\n";
            buttonText.text = "Button: " + mybuf + " (" + joyname[0] + ")";
            mybuf = "";
        }





        // get the value from the joystick     NOTE: it will be between -1.0 to +1.0

        //float yaw = Input.GetAxisRaw("Yaw");
        //Debug.Log($"{x} ; {z} ; {yaw}"); ;
        
        //Vector3 curRotatation = transform.rotation.eulerAngles;

        //curRotatation.x = curRotatation.x + x * 6f; 
        //curRotatation.y = curRotatation.y + yaw * 6f; 
        //curRotatation.z = curRotatation.z + z* 6f; 

        //transform.rotation = Quaternion.Euler(curRotatation);

    }
}