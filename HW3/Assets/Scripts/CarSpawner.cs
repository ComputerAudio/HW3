using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {
    public Transform[] cars;
    public float minSpawnTime = .5f;
    public float maxSpawnTime = 1f;

    private float timer;

    void Start()
    {
        resetTimer();
    }

	void Update()
    {
        timer = Mathf.MoveTowards(timer, 0, Time.deltaTime);
        if (timer <= 0)
        {
            createCar();
            resetTimer();
        }
    }

    void createCar()
    {
        GameObject obj = (GameObject)Instantiate(cars[Random.Range(0, cars.Length)].gameObject, this.transform.position, new Quaternion());
        obj.transform.rotation = this.transform.localRotation;
    }

    void resetTimer()
    {
        timer = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
