using UnityEngine;
using System.Collections;

public class FirstPersonCamera : MonoBehaviour {
    public Transform target;
    public float hSpeed;
    public float vSpeed;
    public float cameraSmoothing = 6f;

    float offsetMag;
    float hInput;
    float vInput;

	// Use this for initialization
	void Start ()
    {
        //offsetMag = (target.position - this.transform.position).magnitude;

	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = target.position;
        horizontalInput(Input.GetAxisRaw("Mouse X"));
        verticalInput(Input.GetAxisRaw("Mouse Y"));
        updateCameraRotation();
	}

    void updateCameraRotation()
    {
        Vector3 goalRot = this.transform.eulerAngles;
        goalRot += new Vector3(vInput * Time.deltaTime * vSpeed, hInput * Time.deltaTime * hSpeed, 0);
        goalRot = new Vector3(goalRot.x, goalRot.y, 0);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(goalRot), Time.deltaTime * cameraSmoothing);

    }

    public void horizontalInput(float hInput)
    {
        this.hInput = hInput;
    }

    public void verticalInput(float vInput)
    {
        this.vInput = -vInput;
    }
}
