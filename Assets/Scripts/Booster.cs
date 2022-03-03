using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public float speed = 1.0f;
    public float acceleration = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);

        transform.position = transform.position + new Vector3(0, acceleration * Time.deltaTime, 0);
    }
}
