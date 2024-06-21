using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    [SerializeField] private GameObject on;
    [SerializeField] private GameObject off;

    public AudioSource leverSound;
    public AudioSource buttonSound;

    [SerializeField] GameObject interactionText;

    private float time = 0.2f;
    private float timer = Time.time;

    public void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        interactionText.SetActive(true);

        timer += Time.deltaTime;
        if (timer >= time)
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (CompareTag("Lever 1"))
                {
                    leverSound.Play();
                    GameStateController.Instance.leverOneOn = !GameStateController.Instance.leverOneOn;
                }
                else if (CompareTag("Lever 2"))
                {
                    leverSound.Play();
                    GameStateController.Instance.leverTwoOn = !GameStateController.Instance.leverTwoOn;
                }
                else if (CompareTag("Lever 3"))
                {
                    leverSound.Play();
                    GameStateController.Instance.leverThreeOn = !GameStateController.Instance.leverThreeOn;
                }
                else if (CompareTag("Button 1"))
                {
                    buttonSound.Play();
                    GameStateController.Instance.buttonOneOn = !GameStateController.Instance.buttonOneOn;
                }
                else if (CompareTag("Button 2"))
                {
                    buttonSound.Play();
                    GameStateController.Instance.buttonTwoOn = !GameStateController.Instance.buttonTwoOn;
                }

                on.SetActive(false);
                off.SetActive(true);

                timer = 0;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        interactionText.SetActive(false);
    }
}
