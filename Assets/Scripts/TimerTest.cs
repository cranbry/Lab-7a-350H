using UnityEngine;

public class TimerTest : MonoBehaviour
{
    private Timer timer;
    private float startTime;

    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 5.0f;
        timer.Run();
        startTime = Time.time;
    }

    void Update()
    {
        if (timer.Finished)
        {
            float elapsedTime = Time.time - startTime;
            Debug.Log("Timer ran: " + elapsedTime + " seconds.");
            timer.Run();
            startTime = Time.time;
        }
    }
}