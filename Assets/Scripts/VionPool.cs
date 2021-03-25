using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VionPool : MonoBehaviour
{
    [SerializeField] GameObject vion;
    [Range(1, 20)] [SerializeField] int quantity = 5;

    [Range(1, 100)] public float radius = 10;
    [Range(0, 10)] public float offset = 0.0f;

    public float rotationSpeed = 1;

    public static VionPool instance;


    public UnityEvent OnCollision;

    [ContextMenu("Generate")]
    private void Generate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            float angle = i * (Mathf.PI * 2f) / transform.childCount;
            transform.GetChild(i).localPosition = new Vector3(Mathf.Cos(offset + angle) * radius, 0, Mathf.Sin(offset + angle) * radius);
            transform.GetChild(i).LookAt(transform.position);
            transform.GetChild(i).Rotate(0, -90, 0);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        for (int i = 0; i < quantity; i++)
        {

            float angle = i * (Mathf.PI * 2f) / quantity;
            Vector3 pos = new Vector3(Mathf.Cos(offset + angle) * radius, 0, Mathf.Sin(offset + angle) * radius) + transform.position;
            Gizmos.DrawSphere(pos, 1);
        }
    }

    private void Start()
    {
        instance = this;

        SelectNewVion();
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

    }

    [ContextMenu("Enable First Child")]
    public void SelectNewVion()
    {
        if (transform.childCount == 0)
        {
            GameManager.KKWin();
            return;
        }



        vion.transform.position = transform.GetChild(0).transform.position;
        vion.transform.rotation = transform.GetChild(0).transform.rotation;

        Destroy(transform.GetChild(0).gameObject);

    }
    public static int GetLifeCount()
    {
        return instance.transform.childCount;
    }
}
