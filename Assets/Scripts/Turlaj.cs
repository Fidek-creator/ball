using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turlaj : MonoBehaviour {

	[SerializeField]
	Transform transformTarget;
	// Update is called once per frame
	void Update () 
	{
		transform.position = transformTarget.position;
	}
}
