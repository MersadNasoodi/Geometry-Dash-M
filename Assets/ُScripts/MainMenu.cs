using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Slider slider;
    public TMP_Text progressText;

    private void Start()
    {
        slider.value = PlayerPrefs.GetInt("HighScore");
        progressText.text = PlayerPrefs.GetInt("HighScore").ToString() + "%";
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    
    }
}
