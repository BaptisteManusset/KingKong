using CarterGames.Assets.AudioManager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FloatReference pv;

    public static GameManager instance;
    public static bool KKgameOver = false;
    public static bool endOfGame = false;


    public UnityEvent winGorille;
    public UnityEvent lostGorille;


    public AudioManager audio;


    private void Awake()
    {
        if (instance == null)
            instance = this;

        pv.value = 100;


        KKgameOver = false;
        endOfGame = false;
    }

    private void Start()
    {
        if (instance == null)
            instance = this;
    }


    public static void KKTakeDamage(float value)
    {
        GameManager.instance.audio.Play("squeeze-toy-1", Random.Range(.8f, 1.2f), Random.Range(.8f, 1.2f));

        instance.pv.value -= value;

        if (instance.pv.value <= 0)
        {
            KKGameOver();
        }
    }

    private static void KKGameOver()
    {
        Debug.Log("Game over King kong");
        KKgameOver = true;
        endOfGame = true;

        instance.lostGorille.Invoke();
    }
    public static void KKWin()
    {
        Debug.Log("Win King kong");
        KKgameOver = false;
        endOfGame = true;

        instance.winGorille.Invoke();
    }




    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
