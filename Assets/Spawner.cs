using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public Vector3 pos;
    public int min = 10;


    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 1, 1);
    }

    void Spawn()
    {


        Collider[] colliders = Physics.OverlapSphere(transform.position + pos, 3);
        int count = 0;
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].CompareTag("projectile"))
            {
                count++;
            }
        }

        if (count <= min) Instantiate(obj, transform.position + pos, Quaternion.identity, transform);
    }
}
