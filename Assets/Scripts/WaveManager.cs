using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;
    public List<SpawnManager> spawnPoints;

    public int curWave = 1;
    public float prevTime;

    // Start is called before the first frame update
    void Start()
    {
        prevTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup - prevTime > 1.0)
        {
            prevTime = Time.realtimeSinceStartup;
            spawnPoints[Random.Range(0, spawnPoints.Count)].spawn();

        }
    }
}
