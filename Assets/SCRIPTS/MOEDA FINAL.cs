using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public GameObject gameOverPanel;

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {
            gameOverPanel.SetActive(true);
        }
    }
}