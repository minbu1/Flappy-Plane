using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed = 0.2f;
    private Material material;
    private Vector2 offset;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        offset += Vector2.left * speed * Time.deltaTime;
        material.mainTextureOffset = offset;
    }
}
