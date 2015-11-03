using UnityEngine;
using System.Collections;

public class AmbientScript : MonoBehaviour {
    public float timeStep = .5f;
    AudioSource aSource;
    AudioClip pendingClip;
    bool changeClip;
    float maxVolume;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
        maxVolume = aSource.volume;
    }

    void Update()
    {
        if (!changeClip)
        {
            aSource.volume = Mathf.MoveTowards(aSource.volume, maxVolume, Time.deltaTime * timeStep);
        }
        else
        {
            aSource.volume = Mathf.MoveTowards(aSource.volume, 0, Time.deltaTime * timeStep);
            if (aSource.volume <= 0)
            {
                changeClip = true;
                aSource.Stop();
                aSource.clip = pendingClip;
                aSource.Play();
            }
        }
    }

    public void changeAmbientSound(AudioClip aClip)
    {
        if (aClip.name == aSource.clip.name)
        {
            return;
        }
        pendingClip = aClip;
        changeClip = true;

    }
}
