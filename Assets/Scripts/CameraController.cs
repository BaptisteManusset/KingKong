using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target = null;
    
    [SerializeField]
    private Vector3 offset = Vector3.zero;
    private Vector3 followVelocity;

    [SerializeField]
    private float smoothTime = 0f;


    private void LateUpdate()
    {
        if (target == null) return;


        transform.LookAt(target);

        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.SmoothDamp(transform.position, desiredPos, ref followVelocity, smoothTime);

        transform.position = smoothedPos;
    }
}