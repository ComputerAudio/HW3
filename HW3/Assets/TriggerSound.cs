using UnityEngine;
using System.Collections;

public class TriggerSound : MonoBehaviour {
    public bool playOnce;
    public AudioClip aClip;

    bool soundPlayed;
    AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (playOnce && soundPlayed)
            {
                return;
            }
            aSource.Stop();
            aSource.clip = aClip;
            aSource.Play();
            soundPlayed = true;
        }
    }
}
