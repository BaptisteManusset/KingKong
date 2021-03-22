using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class animController : MonoBehaviour
{
    public UnityEvent onEnd;

    public void End()
    {
        onEnd.Invoke();
        Debug.Log("end Animation");

        gameObject.SetActive(false);
    }
}
