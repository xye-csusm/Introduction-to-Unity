using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller1 : MonoBehaviour {

	public float speed;
	private Vector3 moveDirection; 

	// Use this for initialization
	IEnumerator Start () {
		//StartCoroutine(Counter());
		//yield return StartCoroutine(Counter());
		speed = 10.0f;
		moveDirection = Vector3.zero;
		yield break;
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController>();
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
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



