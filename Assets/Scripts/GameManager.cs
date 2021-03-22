using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FloatReference pv;

    public static GameManager instance;
    public static bool KKgameOver = false;
    public static bool endOfGame = false;


    public UnityEvent winGorille;
    public UnityEvent lostGorille;



    private void Awake()
    {
        if (instance == null)
            instance = this;

        pv.value = 100;
    }

    private void Start()
    {
        if (instance == null)
            instance = this;
    }


    public static void KKTakeDamage(float value)
    {

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

        instance.winGorille.Invoke();
    }
    public static void KKWin()
    {
        Debug.Log("Win King kong");
        KKgameOver = false;
        endOfGame = true;

        instance.winGorille.Invoke();
    }
}
