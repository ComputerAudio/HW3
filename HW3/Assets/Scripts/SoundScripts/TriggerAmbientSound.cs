using UnityEngine;
using System.Collections;

public class TriggerAmbientSound : MonoBehaviour {
    public AudioClip aClip;
    public AudioSource ambientSound;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (ambientSound.clip.name == aClip.name)
            {
                return;
            }
            ambientSound.Stop();
            ambientSound.clip = aClip;
            ambientSound.Play();
        }
    }
}
