using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        Debug.Log("0.01 Start");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,speed/10,0f);
    }
}
