using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Paused;

    public bool gamePaused;

    void Start()
    {
        Paused.SetActive(false);
    } 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamePaused)
            {
                returnGame();
            }
            else
            {
                pauseSetUp();
            }
        }
    }

    public void pauseSetUp()
    {
        Paused.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void returnGame()
    {
        Paused.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void returnMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
