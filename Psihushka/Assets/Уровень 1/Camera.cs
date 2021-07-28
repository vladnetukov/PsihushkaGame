using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform personPos;
   	
    void Start()
    {
       
    }
	// Update is called once per frame
	void Update () {
        if (personPos.position.y-1.5f > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, personPos.position.y-1.5f, transform.position.z);
        }


    }

  
  
}
