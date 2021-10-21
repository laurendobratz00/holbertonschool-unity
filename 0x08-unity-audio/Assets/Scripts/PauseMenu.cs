using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEditor;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    private bool isPaused;

    public AudioMixerSnapshot unpaused;

    public AudioMixerSnapshot paused;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Pause();
        }

        else
        {
            Resume();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PauseCanvas.SetActive(true);
        paused.TransitionTo(.01f);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
        isPaused = false;
        unpaused.TransitionTo(.01f);
    }

    void OnGUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Options()
    {
        SceneManager.LoadScene(1);
    }
}
