using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<Timer>().enabled = true;
            //transform.position = new Vector3(0, 10, 0);
            //GetComponent<CharacterController>().enabled = true;
        }
    }
}

// This script enables the Timer script and start counting up
// as soon as the Player exits the TimerTrigger‘s Collider.
