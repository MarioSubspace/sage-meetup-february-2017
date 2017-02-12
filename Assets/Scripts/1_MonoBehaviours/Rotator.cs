using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public Vector3 rotationAxis;
	public float angularSpeed;

	void Update()
	{
		transform.RotateAround (rotationAxis, angularSpeed * Time.deltaTime);
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position, transform.position + 2 * rotationAxis);
	}
}
