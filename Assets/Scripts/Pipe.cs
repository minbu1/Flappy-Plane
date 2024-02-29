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
            var x = Random.Range(9.2f, 21.15f);
            transform.position = new Vector3(x, y);
        }
    }

    private void Start()
    {
        
    }
}
