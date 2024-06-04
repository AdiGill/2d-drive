using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    //forward is Y axis
    public float speed;
    private float idleVar = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        
        laneChanger();
    }
    void laneChanger(){
        if (Input.GetKey("d") && transform.position.x <= 7.75f){
            transform.position = transform.position + new Vector3(0.5f,0f,0f);
            if( transform.rotation.z>-0.2f){
                transform.Rotate(0f,0f,-4f);
            }
        }
        
        else if (Input.GetKey("a")&& transform.position.x >= -9f){
            transform.position = transform.position + new Vector3(-0.5f,0f,0f);
            if( transform.rotation.z<0.2f){
                transform.Rotate(0f,0f,4f);
            }
            
        }
        else{
            if(transform.rotation.z>0f){
                transform.Rotate(0f,0f,-1f);
            }
            if(transform.rotation.z<0f){
                transform.Rotate(0f,0f,1f);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Obstacle"){
            FindObjectOfType<gameManager>().GameOver();
        }
        else if(other.gameObject.tag == "NearMiss"){
            FindObjectOfType<gameManager>().IncreaseScore();
        }

    }
}
