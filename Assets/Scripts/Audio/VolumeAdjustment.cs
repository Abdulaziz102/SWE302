using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolumeAdjustment : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateVolume();
    }

    // called when the game is terminated
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
    private void UpdateVolume()
    {
        foreach (var VARIABLE in FindObjectsOfType<AudioSource>())
        {
            VARIABLE.volume = PlayerPrefs.GetFloat("Volume");
        }
    }
}
