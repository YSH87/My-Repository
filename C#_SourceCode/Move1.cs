using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour {

	public float speed = 10f;
	private Rigidbody playerRigibody;
	public GameManager gameManager;

	void Start (){
		playerRigibody = GetComponent<Rigidbody>();
	}
	
	void Update (){
		if(gameManager.isGameOver == true)
		{
			return;
		}
		
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");
		float fallSpeed = playerRigibody.velocity.y;

		Vector3 velocity = new Vector3(inputX,0,inputZ);
		velocity = velocity * speed;
		velocity.y = fallSpeed;

		playerRigibody.velocity = velocity;
	}
}
