using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 15f;
    private float offScreen;
    void Start()
    {
        offScreen = Camera.main.ScreenToWorldPoint(Vector3.down).y - 15f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= Vector3.down * speed *Time.deltaTime ;

        if(transform.position.y<offScreen){
            Destroy(gameObject);

        }
    }
}
