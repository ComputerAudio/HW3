using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    WalkMechanics walkMechanics;

	// Use this for initialization
	void Start () {
        walkMechanics = GetComponent<WalkMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        walkMechanics.horizontalInput(Input.GetAxisRaw("Horizontal"));
        walkMechanics.verticalInput(Input.GetAxisRaw("Vertical"));
	}
}
