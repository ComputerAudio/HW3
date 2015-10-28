using UnityEngine;
using System.Collections;

public class CarDrive : MonoBehaviour {
    public float speed;

    Vector3 origin;

    void Start()
    {
        origin = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        checkDelete();
    }

    void checkDelete()
    {
        float mag = (transform.position - origin).magnitude;
        if (mag > 100)
        {
            Destroy(this.gameObject);
        }
    }
}
