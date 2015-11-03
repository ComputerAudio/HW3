using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class RandomSound : MonoBehaviour {
    public AudioClip[] randomClips;
    public float delayMax = 4f;
    public float delayMin = 8f;

    float delayTimer;
    AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        delayTimer = Mathf.MoveTowards(delayTimer, 0, Time.deltaTime);
        if (delayTimer <= 0)
        {
            chooseSound();
        }
    }

    void chooseSound()
    {
        aSource.Stop();
        aSource.clip = randomClips[Random.Range(0, randomClips.Length)];
        aSource.Play();
        delayTimer = Random.Range(delayMin, delayMax);
    }
}
