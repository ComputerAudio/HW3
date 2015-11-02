using UnityEngine;
using System.Collections;

public class CarDrive : MonoBehaviour {
    public float speed;
    AudioSource aSource;

    Vector3 origin;

    void Start()
    {
        origin = transform.position;
        aSource = GetComponent<AudioSource>();
        setUpEngineSound();
    }

    void setUpEngineSound()
    {
        aSource.pitch = Random.Range(.75f, 1.2f);
        aSource.volume = Random.Range(.5f, .7f);
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
