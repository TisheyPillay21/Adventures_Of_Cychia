using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject controlsPanel;

    public AudioSource mainSound;
    public AudioSource pauseSound;

    private void Start()
    {
        pauseSound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainSound.Pause();
            pauseSound.Play();

            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
    }

    public void OnResumeClicked()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);

        pauseSound.Stop();
        mainSound.Play();
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
