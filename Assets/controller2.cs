using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller2 : MonoBehaviour {

	public float speed;
	private Vector3 moveDirection; 

	// Use this for initialization
	IEnumerator Start () {
		yield return StartCoroutine(Counter());
		speed = 10.0f;
		moveDirection = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		//yield return StartCoroutine(Counter());
		CharacterController controller = GetComponent<CharacterController>();
		moveDirection = new Vector3(1, 0, 1);
		moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
	}

	IEnumerator Counter() {
     for(int i=0; i<10; i++) {
       Debug.Log (i.ToString() + " Seconds have elapsed");
       yield return new WaitForSeconds(1.0f);
     }
   }
}



