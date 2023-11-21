using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSpawner : MonoBehaviour
{
    public GameObject Hands;
    public float SpawnRate = 2;
    public float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnHands();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < SpawnRate)
        {
            Timer = Timer + Time.deltaTime;
        }
        else
        {
            spawnHands();
            Timer = 0;
        }
    }
    private void spawnHands()
    {
        Instantiate(Hands, transform.position, transform.rotation);
    }
}
