using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VionMove : MonoBehaviour
{

    #region rotation
    [Header("Rotation")]
    public float forwardSpeed = 25f;
    public float strafeSpeed = 7.5f;
    public float hoverspeed = 5f;
    private float activeForwardSpeed;
    private float activeStrafeSpeed;
    private float activeHoverSpeed;
    private float forwardAcceleration = 2.5f;
    private float strafeAcceleration = 2f;
    private float hoverAcceleration = 2f;
    public float lookRateSpeed = 90f;
    private Vector2 lookInput, screenCenter, mouseDistance;
    private float rolllnput; public float rollSpeed = 90f, rollAcceleration = 3.5f;
    #endregion



    void Start()
    {
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;


    }



    void Update()
    {
            Movement();
    }

    private void Movement()
    {
        lookInput.x = Input.mousePosition.x; 
        lookInput.y = Input.mousePosition.y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.y;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        mouseDistance = Vector2.ClampMagnitude(mouseDistance, 1f);
        rolllnput = Mathf.Lerp(rolllnput, Input.GetAxisRaw("Roll"), rollAcceleration * Time.deltaTime);

        transform.Rotate(-mouseDistance.y * lookRateSpeed * Time.deltaTime, mouseDistance.x * lookRateSpeed * Time.deltaTime, rolllnput * rollSpeed * Time.deltaTime, Space.Self);
       
        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed, strafeAcceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxisRaw("Hover") * hoverspeed, hoverAcceleration * Time.deltaTime);
   
        
        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime; 
        transform.position += (transform.right * activeStrafeSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision)
    {
        Boom();
    }

    private void Boom()
    {
        

    }
}
