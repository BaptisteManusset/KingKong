using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floatFiller : MonoBehaviour
{

    [SerializeField] Image fill;
    void Update()
    {
        fill.fillAmount = GameManager.pv / 100;
    }
}
