using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionController : MonoBehaviour
{
    CharacterController character;

    public float panangleMax = 50;
    public float TiltAngleMax = 50;
    public float speed = 50;


    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }
    void Update()
    {


        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        float y = Input.GetAxisRaw("Yaw");
        //Debug.Log($"{x} ; {z} ; {y}"); ;

        Vector3 curRotatation = transform.rotation.eulerAngles;

        curRotatation.z = panangleMax * -x;
        curRotatation.x = TiltAngleMax * z;

        transform.rotation = Quaternion.Euler(curRotatation);

        character.Move(transform.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * y );
    }
}
