using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SignInteraction : MonoBehaviour
{
    [SerializeField] GameObject riddlePanel;
    [SerializeField] GameObject interactionText;

    public AudioSource riddleSound;

    public void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        interactionText.SetActive(true);
        
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("E PRESSED");
            riddlePanel.SetActive(true);

            riddleSound.Play();
        }
        
    }

    public void OnTriggerExit(Collider other) 
    {
        interactionText.SetActive(false);
        riddlePanel.SetActive(false);
    } 
}
