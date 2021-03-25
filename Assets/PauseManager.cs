using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static bool isPaused = false;
    public static PauseManager instance;
    public GameObject pauseUi;

    void Start()
    {
        instance = this;
        isPaused = true;
        pauseUi.SetActive(isPaused);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0 : 1;
        pauseUi.SetActive(isPaused);
    }
}
