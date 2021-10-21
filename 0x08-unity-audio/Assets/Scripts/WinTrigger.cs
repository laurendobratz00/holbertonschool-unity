using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject Player;
    public Text TimerText;
    private Timer timer_script;
    public GameObject WinCanvas;

    public AudioSource cheerymonday;

    public AudioSource victorypiano;

    public bool cheery = true;

    public bool victory = false;

    // Start is called before the first frame update
    void Start()
    {
        timer_script = Player.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            WinCanvas.SetActive(true);
            timer_script.Win();
            //other.GetComponent<Timer>().enabled = false;
            //TimerText.text = timer_script.elapsedTime.ToString();
            //TimerText.fontSize = 60;
            //TimerText.color = Color.green;
            if (cheerymonday.isPlaying)
            {
                cheery = false;
                cheerymonday.Stop();
                victory = true;
                victorypiano.Play();
            }
        }
    }
}
