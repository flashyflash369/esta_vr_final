using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	public float speed = 1.0f;


    // Update is called once per frame
    void Update()
    {
    	float horizontalInput = Input.GetAxis("Horizontal");
    	float verticalInput = Input.GetAxis("Vertical");
    	
    	this.transform.Translate(horizontalInput * speed * Time.deltaTime, 0f, verticalInput * speed * Time.deltaTime);    
    }
    
}
