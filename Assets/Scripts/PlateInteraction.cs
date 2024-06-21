using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateInteraction : MonoBehaviour
{
    [SerializeField] private GameObject on;
    [SerializeField] private GameObject off;

    public static bool isOn = false;

    public AudioSource plateSound;

    public void OnTriggerStay(Collider other)
    {
        isOn = true;

        on.SetActive(false);
        off.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        plateSound.Play();

        isOn = false;

        on.SetActive(true);
        off.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        plateSound.Play();
    }
}
