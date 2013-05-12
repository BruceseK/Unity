using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public Rigidbody player;
	public float speed = 5;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Movement();
	
	}
	
	void Movement() {
		if( Input.GetAxis("Horizontal") != 0 )
		{
			player.transform.Translate( Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
		}
	}
}
