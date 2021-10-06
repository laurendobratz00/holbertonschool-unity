using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CutsceneController : MonoBehaviour
{
    public GameObject PlayerCapsule;
    public GameObject Player;
    public GameObject PlayerFollowCamera;
    public GameObject TimerCanvas;
    public Camera CutsceneCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Enabled(string i)
    {
        if (i.Equals("Enabled"))
        {
            Player.GetComponent<PlayerController>().enabled = true;
            GetComponent<CutsceneController>().enabled = false;
            PlayerCapsule.GetComponent<PlayerController>().enabled = true;
            TimerCanvas.SetActive(true);
            CutsceneCamera.enabled = false;
            PlayerFollowCamera.SetActive(true);
        }
    }
}
