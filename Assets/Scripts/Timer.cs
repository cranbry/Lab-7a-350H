using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Duration { get; set; }
    public bool Finished { get; private set; }
    public float ElapsedTime { get; private set; }
    private bool isRunning = false;

    public void Run()
    {
        Finished = false;
        isRunning = true;
        ElapsedTime = 0f;
    }

    void Update()
    {
        if (isRunning)
        {
            ElapsedTime += Time.deltaTime;

            if (ElapsedTime >= Duration)
            {
                Finished = true;
                isRunning = false;
            }
        }
    }
}