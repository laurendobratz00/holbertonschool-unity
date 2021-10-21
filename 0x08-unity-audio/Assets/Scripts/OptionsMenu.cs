using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject invertYToggle;
    public bool isInverted;

    public AudioMixer background;
    public AudioMixer soundeffects;

    public Slider bSlider;
    public Slider seSlider;
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
        bSlider.value = PlayerPrefs.GetFloat("BGMvolume", 0.75f);
        seSlider.value = PlayerPrefs.GetFloat("SFXvolume", 0.75f);
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
    public void BackgroundToggle(float sliderValue)
    {
        background.SetFloat("BGMvolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("BGMvolume", sliderValue);
    }
    public void SoundEffectsToggle(float sliderValue)
    {
        soundeffects.SetFloat("SFXvolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXvolume", sliderValue);
    }
}
