using UnityEngine;
using UnityEngine.UI;


public class LinearTimer : MonoBehaviour
{
    public Image timerBar;
    public float maxTime = 6f;
    private float timeLeft;
    public GameObject timesuptext;
    public GameObject GameOver;

    void Start()
    {
        GameOver.SetActive(false);
        timesuptext.SetActive(false);
        timerBar = GetComponent<Image> ();
        timeLeft = maxTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime; 
            timerBar.fillAmount = timeLeft / maxTime; 
        }
        else
        {
            GameOver.SetActive(true);
            timesuptext.SetActive(true);
            Debug.Log("Time's up!");
            timeLeft = 0;
        }
    }
}