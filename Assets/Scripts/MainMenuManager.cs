using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public string _gameplay;
    public GameObject settingsUI;
    public GameObject exitPrompt;
    public GameObject aboutPanel;

    public bool isSetting = false;
    public bool isExit = false;
    public bool isAbout = false;
    // Start is called before the first frame update
    void Start()
    {
        settingsUI.SetActive(false);
        exitPrompt.SetActive(false);
        aboutPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(_gameplay);
    }
   public void ExitGame()
    {
        Application.Quit();
    }

    public void SettingsUI()
    {
        if (!isSetting)
        {
            settingsUI.SetActive(true);
            isSetting = true;
        }
        else
        {
            settingsUI.SetActive(false);
            isSetting = false;
        }
    }
    public void exitUI()
    {
        if (!isExit)
        {
            exitPrompt.SetActive(true);
            isExit = true;
        }
        else
        {
            exitPrompt.SetActive(false);
            isExit = false;
        }
    }

    public void aboutUI()
    {
        if (!isAbout)
        {
            aboutPanel.SetActive(true);
            isAbout = true;
        }
        else
        {
            aboutPanel.SetActive(false);
            isAbout = false;
        }
    }
}
