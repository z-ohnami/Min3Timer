using UnityEngine;

public class PauseButton : MonoBehaviour
{

    private AppTimer appTimer;
    // Start is called before the first frame update
    void Start()
    {
        appTimer = AppTimer.GetInstance();
    }

    public void PauseTimer()
    {
        appTimer.PauseTimer();
    }
}
