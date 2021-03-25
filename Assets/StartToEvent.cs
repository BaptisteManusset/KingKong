using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartToEvent : MonoBehaviour
{
    public UnityEvent unityEvent;
    Animation animation;

    void Awake() => unityEvent.Invoke();

    private void Start()
    {
        animation = GetComponent<Animation>();
        animation.Play();
    }
}
