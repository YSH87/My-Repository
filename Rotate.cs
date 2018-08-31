using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float speed = 45f;

	void Update ()
	{
		transform.Rotate(speed * Time.deltaTime,speed * Time.deltaTime,speed  * Time.deltaTime);
	}
}
