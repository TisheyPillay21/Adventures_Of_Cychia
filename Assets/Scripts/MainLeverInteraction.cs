using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLeverInteraction : MonoBehaviour
{
    [SerializeField] private GameObject on;
    [SerializeField] private GameObject off;
    [SerializeField] private GameObject bridge;

    [SerializeField] GameObject interactionText;

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (GameStateController.Instance.IsMainLeverActive() == true)
        {
            interactionText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                bridge.SetActive(true);

                on.SetActive(false);
                off.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        interactionText.SetActive(false);
    }
}
