using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")][SerializeField] private float levelLoadDelay = 1f;
    [Tooltip("FX prefab om player")][SerializeField] private GameObject deathFX;

    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene",levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
    }

    private void ReloadScene() //string referenced
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
