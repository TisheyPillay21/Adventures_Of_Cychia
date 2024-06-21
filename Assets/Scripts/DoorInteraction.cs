using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    [SerializeField] private GameObject on;
    [SerializeField] private GameObject off;

    private bool isOpened = false;

    // Update is called once per frame
    void Update()
    {
       if (GameStateController.Instance.IsButtonsCorrect() == true && PlateInteraction.isOn == true)
        {
            on.SetActive(false);
            off.SetActive(true);

            isOpened = true;
        }
        else
        {
            on.SetActive(true);
            off.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (isOpened == true)
        {
            SceneManager.LoadSceneAsync("MainMenuScene", LoadSceneMode.Single);
        }
    }
}
