using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerVelocity : MonoBehaviour {

	[SerializeField]
	Vector3 v3Force;
	[SerializeField]
	KeyCode keyPositive;
	[SerializeField]
	KeyCode keyNegative;

	private Vector3 spawn;

	void Start()
    {
		spawn = transform.position;
	}
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(keyPositive))
			GetComponent<Rigidbody>().velocity += v3Force;
		if (Input.GetKey(keyNegative))
			GetComponent<Rigidbody>().velocity -= v3Force;
		
	}
	void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
			transform.position = spawn;
        }
    }

    [System.Obsolete]
    void OnTriggerEnter(Collider other)
    {
		if(other.transform.tag == "Goal") 
		{
			Manager.CompleteLevel();
		}
    }
}
