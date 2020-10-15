using UnityEngine;
using UnityEngine.UI;

public class TotalSecondsToggle : MonoBehaviour
{
    public float Seconds;
    private AppTimer appTimer;

    void Start()
    {
        appTimer = AppTimer.GetInstance();
    }

    public void UpdateTotalSeconds(Toggle change)
    {
        if (change.isOn)
        {
            appTimer.UpdateTotalSeconds(Seconds);
        }
    }
}
