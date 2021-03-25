using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VionShot : MonoBehaviour
{

    public GameObject bullet;

    public Transform shotPosition;
    public float loader = 0;
    public float max = 1;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (GameManager.endOfGame == true || PauseManager.isPaused) return;

            loader += Time.deltaTime;

            if (loader >= max)
            {
                Instantiate(bullet, shotPosition.position, shotPosition.rotation);
                loader -= max;
                GameManager.instance.audio.Play("Impact_Buble");
            }
        }
    }
}
