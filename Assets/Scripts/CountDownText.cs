using UnityEngine;
using UnityEngine.UI;

public class CountDownText : MonoBehaviour
{
    private AppTimer appTimer;

    // Start is called before the first frame update
    void Start()
    {
        appTimer = AppTimer.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        int leftMinutes = (int)(appTimer.GetLeftSeconds() / 60);
        int leftSeconds = (int)(appTimer.GetLeftSeconds() % 60);
        GetComponent<Text>().text = leftMinutes.ToString("D2") + ":" + leftSeconds.ToString("D2");
    }
}
