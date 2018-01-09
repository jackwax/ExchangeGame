using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour {
	public GameObject target;
	public Rigidbody rb;
	private NavMeshAgent agent;
	private bool following;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		agent = GetComponent<NavMeshAgent>();
		following = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F)){
			following = true;
		}

		if (Input.GetKeyDown(KeyCode.G)){
			following = false;
		}

		if (following) {
			follow ();
		}
	}

	void follow () {
		Transform targetCoor = target.GetComponent<Transform> ();
		agent.destination = targetCoor.position;
	}
}
