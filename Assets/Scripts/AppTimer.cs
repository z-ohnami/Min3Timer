using System.Timers;

public class AppTimer
{
    private static AppTimer appTimer;

    public static AppTimer GetInstance()
    {
        if (appTimer == null)
        {
            appTimer = new AppTimer();
            return appTimer;
        }
        return appTimer;
    }

    private float elapsed = 0;
    private float totalSeconds = 180;
    private Timer timer;
    private bool running = false;
    private bool started = false;

    private AppTimer()
    {
        timer = new Timer();
        timer.Interval = 1000;
        timer.Enabled = true;

        timer.Elapsed += (System.Object source, ElapsedEventArgs e) => {
            elapsed += 1;
            StopIfNeeded();
        };
        timer.Stop();
    }

    public void StartTimer()
    {
        timer.Start();
        started = true;
        running = true;
    }

    public void PauseTimer()
    {
        timer.Stop();
        running = false;
    }

    public void StopTimer()
    {
        timer.Stop();
        started = false;
        running = false;
        elapsed = 0;
    }

    private void StopIfNeeded()
    {
        if (elapsed >= totalSeconds)
        {
            StopTimer();
        }
    }

    public float GetElapsed()
    {
        return elapsed;
    }

    public bool IsRunning()
    {
        return running;
    }

    public bool IsStarted()
    {
        return started;
    }

    public float GetTotalSeconds()
    {
        return totalSeconds;
    }

    public float GetLeftSeconds()
    {
        return totalSeconds - elapsed;
    }

    public void UpdateTotalSeconds(float seconds)
    {
        totalSeconds = seconds;
    }
}
