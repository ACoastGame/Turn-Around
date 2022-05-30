using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingCharacter_Control : MonoBehaviour {

	private StandingCharacter_Control StandingMovement;
	private CharacterMovement_After AfterMovement;

	// Use this for initialization
	void Start()
	{
		StandingMovement = GetComponent<StandingCharacter_Control>();
		AfterMovement = GetComponent<CharacterMovement_After>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Trigger"))
		{
			StandingMovement.enabled = false;
			AfterMovement.enabled = true;
		}
	}
}
