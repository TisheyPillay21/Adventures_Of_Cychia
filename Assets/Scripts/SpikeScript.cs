using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            return;
        } else if (other.CompareTag("Bridge"))
        {
            return;
        }

        Destroy(other.gameObject);
    }
}
