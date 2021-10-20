using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public GameObject invertYToggle;
    public bool isInverted;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("isInvertedY") == 1)
        {
            invertYToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
            isInverted = true;
        }
        else
        {
            invertYToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
            isInverted = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        int previous = PlayerPrefs.GetInt("Scene");
        SceneManager.LoadScene(previous);
    }

    public void Apply()
    {
        if (isInverted == true)
        {
            PlayerPrefs.SetInt("isInvertedY", 1);
        }
        else
        {
            PlayerPrefs.SetInt("isInvertedY", 0);
        }
    }

    public void ToggleInvert()
    {
        isInverted = !isInverted;
    }

    
}
