using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrRotate : MonoBehaviour {

    public float angleOfRotation = 45;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void RotateLeft()
    {
        transform.Rotate(Vector3.up, -angleOfRotation);
    }

   public void RotateRight()
    {
        transform.Rotate(Vector3.up, angleOfRotation);
    }
}
