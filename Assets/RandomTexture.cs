using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTexture : MonoBehaviour
{
    [SerializeField] Material[] materials;
    MeshRenderer render;

    [ContextMenu("Change Texture")]
    void ChangeTexture()
    {
        render = GetComponentInChildren<MeshRenderer>();
        render.material = materials[Random.Range(0, materials.Length)];
    }
}
