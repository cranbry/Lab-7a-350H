// using System;
using UnityEngine;

public class spawnTimer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject ball;
    Timer spawnTiming;
    private const float SPAWN_MIN_TIME = 2f;
    private const float SPAWN_MAX_TIME = 4f;
    private const float SPAWN_MIN_X = -8f;
    private const float SPAWN_MAX_X = 8f;
    private const float SPAWN_MIN_Y = -5f;
    private const float SPAWN_MAX_Y = 5f;
    void Start()
    {
        spawnTiming = gameObject.AddComponent<Timer>();
        spawnTiming.Duration = Random.Range(SPAWN_MIN_TIME, SPAWN_MAX_TIME);
        spawnTiming.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTiming.Finished)
        {
            Instantiate(ball, new Vector3(Random.Range(SPAWN_MIN_Y, SPAWN_MAX_Y),
                                          Random.Range(SPAWN_MAX_X, SPAWN_MIN_X),
                                          0),
                                          Quaternion.identity);
            spawnTiming.Run();
        }
    }
}
