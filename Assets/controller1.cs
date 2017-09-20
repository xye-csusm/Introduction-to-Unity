using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller1 : MonoBehaviour {

	public float speed;
	private Vector3 direction;
	private Vector3 velocity;

	// Use this for initialization
	IEnumerator Start () {
		StartCoroutine(Counter());
		yield return StartCoroutine(Counter());
		speed = 100.0f;
		direction = Vector3.zero;
		yield break;
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController>();
		direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		direction = transform.TransformDirection(direction);
        velocity = direction * speed;
        controller.Move(velocity * Time.deltaTime);
	}

	IEnumerator Counter() {
     for(int i=0; i<10; i++) {
       Debug.Log (i.ToString() + " Seconds have elapsed");
       yield return new WaitForSeconds(1.0f);
     }
   }
}



