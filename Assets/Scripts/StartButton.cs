using UnityEngine;

public class StartButton : MonoBehaviour
{

    private AppTimer appTimer;
    // Start is called before the first frame update
    void Start()
    {
        appTimer = AppTimer.GetInstance();
    }

    public void StartTimer()
    {
        appTimer.StartTimer();
    }
}
