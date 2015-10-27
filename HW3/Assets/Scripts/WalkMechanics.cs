using UnityEngine;
using System.Collections;

public class WalkMechanics : MonoBehaviour {
    public float speed = 5f;
    public float acceleration = 10f;

    float hInput;
    float vInput;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        updateMotion();
    }

    void updateMotion()
    {
        Vector3 walkVector = getWalkVector();
        float walkScale = Mathf.Max(Mathf.Abs(hInput), Mathf.Abs(vInput));
        Vector3 goalVec = walkScale * walkVector * speed + new Vector3(0, rigid.velocity.y, 0);

        rigid.velocity = Vector3.Lerp(rigid.velocity, goalVec, Time.deltaTime * acceleration);
    }

    protected virtual Vector3 getWalkVector()
    {
        return new Vector3(hInput, 0, vInput).normalized;
    }

    public void horizontalInput(float hInput)
    {
        this.hInput = hInput;
    }

    public void verticalInput(float vInput)
    {
        this.vInput = vInput;
    }

    public float getHInput()
    {
        return hInput;
    }

    public float getVInput()
    {
        return vInput;
    }

}
