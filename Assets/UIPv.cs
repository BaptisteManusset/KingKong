using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPv : MonoBehaviour
{
    public Image[] pvs;
    private void FixedUpdate()
    {
        UpdatePV();
    }


    void UpdatePV()
    {
        int pv = VionPool.GetLifeCount();

        for (int i = 0; i < pvs.Length; i++)
        {
            pvs[i].gameObject.SetActive(pv < i ? false : true);
        }
    }
}
