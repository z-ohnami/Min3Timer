using UnityEngine;

public class StopButton : MonoBehaviour
{

    private AppTimer appTimer;
    // Start is called before the first frame update
    void Start()
    {
        appTimer = AppTimer.GetInstance();
    }

    public void StopTimer()
    {
        appTimer.StopTimer();
    }
}
