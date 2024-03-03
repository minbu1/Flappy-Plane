using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= -10f)
        {
            Destroy(gameObject);

        }
    }
        
    private void Start()
    {
        var randomY = Random.Range(-2.4f, 1.51f);
        transform.position = new Vector3(transform.position.x, randomY, transform.position.z);
    }

}
