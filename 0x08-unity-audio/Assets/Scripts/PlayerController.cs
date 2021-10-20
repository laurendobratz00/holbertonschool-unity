using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(0, 10, 0);
            GetComponent<CharacterController>().enabled = true;
        }
    }
}
