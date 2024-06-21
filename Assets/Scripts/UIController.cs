using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject controlsPanel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
    }

    public void OnResumeClicked()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void OnRestartClicked()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
    }

    public void OnExitClicked()
    {
        SceneManager.LoadSceneAsync("MainMenuScene", LoadSceneMode.Single);
    }

    public void OnExitGameClicked()
    {
        Application.Quit();
    }

    public void OnControlsClicked()
    {
        controlsPanel.SetActive(true);
    }

    public void OnControlsCloseClicked()
    {
        controlsPanel.SetActive(false);
    }
}
