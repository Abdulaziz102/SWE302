using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject options;
    public GameObject pauseMenu;
    
    public void ResumeClicked()
    {
        Time.timeScale = 1;
        FindObjectOfType<Player>().disableInput = false;
        pauseMenu.SetActive(false);
    }

    public void OptionsClicked()
    {
        pauseMenu.SetActive(false);
        options.SetActive(true);
    }

    public void QuitClicked()
    {
        Levels.Instance.displayMenu();
    }

    public void OptionsBackClicked()
    {
        pauseMenu.SetActive(true);
        options.SetActive(false);
    }

}
