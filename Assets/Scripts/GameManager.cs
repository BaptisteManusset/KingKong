using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FloatReference pv;

    public static GameManager instance;
    public static bool KKgameOver = false;


    private void Awake()
    {
        if (instance == null)
            instance = this;

        pv.value = 100;
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
    }


    private void Update()
    {
        Debug.Log(Input.GetAxisRaw("Test"));
    }
}
