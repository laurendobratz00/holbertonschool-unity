using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
        PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex);
    }

    public void Options()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
