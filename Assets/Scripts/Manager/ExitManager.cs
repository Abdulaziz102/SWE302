using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour, IGameManager
{
    public static ExitManager Instance = null;
    public GameObject pauseMenu;
    public GameObject options;
    private Player player;

    void Awake()
    {
        Instance = this;
        player = FindObjectOfType<Player>();
    }

    public ManagerStatus _Status { get; set; } = ManagerStatus.SHUTDOWN;

    // Start is called before the first frame update
    public void Startup()
    {
        _Status = ManagerStatus.INITIALIZING;
        //
        _Status = ManagerStatus.STARTED;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !player.disableInput)
        {
            player.disableInput = true;
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        // else if (player.disableInput)
        // {
        //     player.disableInput = false;
        //     Time.timeScale = 1;
        //     pauseMenu.SetActive(false);
        //     options.SetActive(false);
        // }
    }
}
