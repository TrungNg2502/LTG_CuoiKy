using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject lossPanel;
    [SerializeField] GameObject pausePanel;
    public void OpenMenu()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void goHome()
    {
        SceneManager.LoadScene("Home");
        Time.timeScale = 1f;
    }
    public void saveGame()
    {
        Time.timeScale = 1f;
    }
    public void continueGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    public void showLossPanel()
    {
        Time.timeScale = 0f;
        lossPanel.SetActive(true);
    }
    public void newGame()
    {
        Time.timeScale = 1f;
        lossPanel.SetActive(false);
        SceneManager.LoadScene("Level_01");
    }
}
