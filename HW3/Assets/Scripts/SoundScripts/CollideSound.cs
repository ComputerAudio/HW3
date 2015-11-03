using UnityEngine;
using System.Collections;

public class CollideSound : MonoBehaviour {
    public AudioClip aClip;
    public float minPitch = .8f;
    public float maxPitch = 1.3f;

    AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
        aSource.clip = aClip;
    }

    void OnCollisionEnter(Collision collision)
    {
        
        Collider col = collision.collider;
        print(col.tag);
        //print(col.tag);
        if (col.tag == "Player")
        {
            playSound();
        }
        
    }

    void playSound()
    {
        aSource.Stop();
        aSource.pitch = Random.Range(minPitch, maxPitch);
        aSource.Play();
    }
}
