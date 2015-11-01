using UnityEngine;
using System.Collections;

public class WalkSounds : MonoBehaviour {
    public float timeStep = 3f;

    AudioSource aSource;
    WalkMechanics walkMechanics;
    float stepTimer;

    void Start()
    {
        walkMechanics = GetComponent<WalkMechanics>();
        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Debug.DrawLine(transform.position, -Vector3.up * 100 + transform.position);
        stepTimer = Mathf.MoveTowards(stepTimer, 0, Time.deltaTime);
        if (!walkMechanics.getIsWalking())
        {
            stepTimer = 0;
            return;
        }
        else if (stepTimer <= 0)
        {
            retrieveFootStepSound();
            stepTimer = timeStep;
        }
    }

    void retrieveFootStepSound()
    {
        RaycastHit hit;

        
        if (Physics.Raycast(transform.position - Vector3.up  *.99f, -Vector3.up, out hit, Mathf.Infinity))
        {
            print("Hello");
            ActiveSound aSound = hit.collider.GetComponent<ActiveSound>();
            if (aSound != null)
            {
                playClip(aSound.aClip);
            }
        }
    }

    void playClip(AudioClip aClip)
    {
        aSource.Stop();
        aSource.pitch = Random.Range(.8f, 1.5f);
        aSource.clip = aClip;
        aSource.Play();
    }
}
