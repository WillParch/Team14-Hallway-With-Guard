using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Player Has Quit the Game");
    }

    public void returnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
