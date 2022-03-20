using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{
    MeshRenderer mr;

    public float animationSpeed=1f;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
