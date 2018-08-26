using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShark : MonoBehaviour {

    float distanceToTravel = 1f;

	// Update is called once per frame
	void Update () {

        transform.Translate(transform.forward * distanceToTravel * Time.deltaTime); 
	}
}
