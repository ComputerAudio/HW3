using UnityEngine;
using System.Collections;

public class MoveSide : MonoBehaviour {
    public Transform[] destination;
    public float speed;

    Vector3[] destinationVector;
    int current;

    void Start()
    {
        destinationVector = new Vector3[destination.Length];
        int i = 0;
        foreach (Transform t in destination)
        {
            destinationVector[i] = t.position;
            i++;
        }
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, destinationVector[current], Time.deltaTime * speed);
        if (Mathf.Abs((transform.position - destinationVector[current]).magnitude) < 1f)
        {
            changeCurrentDestination();
        }
    }

    void changeCurrentDestination()
    {
        current++;
        current = current % destination.Length;
    }
    
}
