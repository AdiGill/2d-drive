using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadMover : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer meshRenderer;
    public float rSpeed = 1f;

    private void Awake(){
        meshRenderer = GetComponent<MeshRenderer>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset+= new Vector2( 0, rSpeed*Time.deltaTime);
    }
}
