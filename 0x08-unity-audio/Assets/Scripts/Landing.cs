using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour
{
    public AudioSource footsteps_landing_grass;
    // Start is called before the first frame update
    void Start()
    {
        footsteps_landing_grass = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            footsteps_landing_grass.Play();
        }
    }
}
