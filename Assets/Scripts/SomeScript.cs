using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    	void Start()
    {
    		transform.position = new Vector3(-20,0,-30);    
    }

    // Update is called once per frame
    	void Update()
    {
    		transform.position = transform.position + new Vector3(0, 0, 0.1f);
		//Debug.Log("Hola");
    }

	void OnCollisionEnter(Collision collision)
    {
		if (collision.gameObject.name == "Restart")
		{
			transform.position = new Vector3(-20,0,-30);    
		}
    }

	void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Trigger enter");
    }

}
