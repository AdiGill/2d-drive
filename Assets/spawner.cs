using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 0.2f;
    public float[] laneMins = {1,2,3,4};
    private float laneW = 4f;

    private float minLane = -8f;
    private float maxLane = 9.5f;

    private void OnEnable(){
        InvokeRepeating(nameof(Spawn), 0, 0.75f);
    }
    private void OnDisable(){
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn(){
        GameObject ped = Instantiate(prefab, transform.position, Quaternion.identity);
        ped.transform.position+= Vector3.right * Random.Range(minLane,maxLane);
        FindObjectOfType<gameManager>().IncreaseScoreOverTime();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
