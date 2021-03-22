using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floatFiller : MonoBehaviour
{
    [SerializeField] FloatReference pv;
    [SerializeField] Image fill;
    void Update()
    {
        fill.fillAmount = pv.value / 100;
    }
}
