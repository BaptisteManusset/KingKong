using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VionPool : MonoBehaviour
{
    [SerializeField] GameObject vion;
    [Range(1, 20)] [SerializeField] int quantity = 5;

    [Range(1, 20)] public float radius = 10;
    [Range(0, 10)] public float offset = 0.0f;

    //void Start() => Generate();

    public float rotationSpeed = 1;



    [ContextMenu("Generate")]
    private void Generate()
    {
        for (int i = 0; i < quantity; i++)
        {
            Instantiate(vion, transform);
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            float angle = i * (Mathf.PI * 2f) / transform.childCount;
            transform.GetChild(i).localPosition = new Vector3(Mathf.Cos(offset + angle) * radius, 0, Mathf.Sin(offset + angle) * radius);
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
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).LookAt(transform.position);
            transform.GetChild(i).Rotate(0, -90, 0);
        }
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

    }

    [ContextMenu("Enable First Child")]
    public void EnableFirstChild()
    {
        Transform child = transform.GetChild(0);
        if (child == null) return;

        VionController vion = child.GetComponent<VionController>();
        if (vion == null) return;
        vion.EnableControl();
    }
}
