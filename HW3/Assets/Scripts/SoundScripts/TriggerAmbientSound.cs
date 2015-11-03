using UnityEngine;
using System.Collections;

public class TriggerAmbientSound : MonoBehaviour {
    public AudioClip aClip;
    public AmbientScript ambientSound;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            ambientSound.changeAmbientSound(aClip);
        }
    }
}
