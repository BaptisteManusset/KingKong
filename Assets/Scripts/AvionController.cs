using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionController : MonoBehaviour
{
    CharacterController character;

    public float panangleMax = 50;
    public float TiltAngleMax = 50;
    public float speed = 50;

    public List<MonoBehaviour> onGrabComponents;

    public bool IsGrabed = false;

    bool on = false;

    public Camera cam;


    Rigidbody rb;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;
        rb.useGravity = false;

        //Off();
    }
    void Update()
    {
        if (IsGrabed == false)
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
            transform.Rotate(Vector3.up * y);
        }
    }

    public void OnGrab()
    {
        IsGrabed = true;
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("projectile"))
        {
            VionPool.instance.SelectNewVion();
        }
    }


    public void On()
    {
        on = true;
        cam.enabled = true;
        transform.parent = null;
    }

    public void Off()
    {
        on = false;
        cam.enabled = false;
    }
}
