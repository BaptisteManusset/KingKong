using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToFollowHead : MonoBehaviour
{
    [SerializeField] Transform head;

    void Update()
    {
        Vector3 rotation = Vector3.zero;

        rotation.y = head.eulerAngles.y;

        transform.eulerAngles = rotation;
    }
}
