using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= -9.69f)
        {
            var y = Random.Range(2.39f, -2.28f);
            var x = Random.Range(9.61f, 10.61f);
            transform.position = new Vector3(x: 9.66f, y: 0, z: 0);
        }
    }
}
