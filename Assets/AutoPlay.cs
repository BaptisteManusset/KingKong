using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPlay : MonoBehaviour
{
    public AudioClip clip;

    void Start()
    {
        GameManager.instance.audio.Play(clip.name);
        
    }
}
