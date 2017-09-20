using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.right * Time.deltaTime * 10, Space.Self);
        transform.Translate(Vector3.left * Time.deltaTime, Space.Self);
	}
}



