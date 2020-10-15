using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private AppTimer appTimer;

    public GameObject StartButton;
    public GameObject PauseButton;
    public GameObject StopButton;

    public GameObject ToggleSeconds1Min;
    public GameObject ToggleSeconds3Min;
    public GameObject ToggleSeconds5Min;

    // Use this for initialization
    void Start()
    {
        appTimer = AppTimer.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if (appTimer.IsStarted())
        {
            StopButton.SetActive(true);
            ToggleSeconds1Min.SetActive(false);
            ToggleSeconds3Min.SetActive(false);
            ToggleSeconds5Min.SetActive(false);
        }
        else
        {
            StopButton.SetActive(false);
            ToggleSeconds1Min.SetActive(true);
            ToggleSeconds3Min.SetActive(true);
            ToggleSeconds5Min.SetActive(true);
        }

        if (appTimer.IsRunning())
        {
            StartButton.SetActive(false);
            PauseButton.SetActive(true);
        }
        else
        {
            StartButton.SetActive(true);
            PauseButton.SetActive(false);
        }
    }
}
