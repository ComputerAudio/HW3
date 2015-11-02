using UnityEngine;
using System.Collections;

public class HonkScript : MonoBehaviour {
    AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            aSource.Stop();
            aSource.pitch = Random.Range(.7f, 1.3f);
            aSource.Play();
        }
    }
}
