using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportVion : MonoBehaviour
{
    public Vector3 position;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {


            Vector3 plpos = other.transform.position;
            plpos.x = position.x;
            plpos.y = transform.position.y;
            plpos.z = position.z;
            other.transform.position = plpos;
            other.transform.Rotate(Vector3.up * 180);

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(position, 10);
        Gizmos.DrawLine(transform.position, position);
    }
}
