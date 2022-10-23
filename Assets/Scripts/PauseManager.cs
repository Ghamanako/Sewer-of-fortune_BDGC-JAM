using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject PausePanel;

    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Time.timeScale = 0;
            PausePanel.SetActive(true);
            isPaused = true;
        } else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            Time.timeScale = 1;
            PausePanel.SetActive(false);
            isPaused = false;
        }
    }

    public void ExitGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            PausePanel.SetActive(false);
            isPaused = false;
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        isPaused = false;
    }
}
