using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour{
    public float speed;
    public float bound;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x <= bound){
            transform.position = new Vector3(31.68f, 0, -1f);
        }
    }
}
