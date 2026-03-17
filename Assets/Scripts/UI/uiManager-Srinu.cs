 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject diffSelectMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject analyticsStatsTab;
    [SerializeField] private GameObject analyticsGraphTab;
    [SerializeField] private GameObject leaderBoard;
    [SerializeField] private GameObject gameOverScreen;


    //bool leaderboardShown = false;

    private void Start()
    {
       GoToStart();
       startMenu.SetActive(true);
       diffSelectMenu.SetActive(false);
       settingsMenu.SetActive(false);
       pauseMenu.SetActive(false);

       analyticsStatsTab.SetActive(false);
       analyticsGraphTab.SetActive(false);
       leaderBoard.SetActive(false);

    }


    private void Update()
    {
        //if (gameManager.sessionEnded && !leaderboardShown)
        //{
        //    Invoke("ShowLeaderBoard", 6f);
        //    leaderboardShown = true;
        //}
        //if (leaderboardShown)
        //{
        //    crane.StopRotation();
        //}
    }




    public void StartGame()
    {
        startMenu.SetActive(false);
        diffSelectMenu.SetActive(true);
        analyticsStatsTab.SetActive(false);
        analyticsGraphTab.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadBeginnerLevel()
    {
        // Load Beginner Level Scene
        diffSelectMenu.SetActive(false);
        pauseMenu.SetActive(false);
        //crane.StartRotation();
        //hook.isGameStarted = true;
        //crane.rotationSpeed = 15f;
        //hook.ropeSpeed = 18f;
        //gameManager.Level = GameManager.diffLevel.Begginer;
    }

    public void LoadIntermediateLevel()
    {
        //Load Inter Level Scene
        diffSelectMenu.SetActive(false);
        pauseMenu.SetActive(false);
        //crane.StartRotation();
        //hook.isGameStarted = true;
        //hook.ropeSpeed = 12f;
        //crane.rotationSpeed = 25f;
        //gameManager.Level = GameManager.diffLevel.Intermidiate;

    }

    public void LoadExpertLevel()
    {

        //Load expert level scene
        diffSelectMenu.SetActive(false);
        pauseMenu.SetActive(false);
        //crane.StartRotation();
        //hook.isGameStarted = true;
        //hook.ropeSpeed = 8f;
        //crane.rotationSpeed = 40f;
        //gameManager.Level = GameManager.diffLevel.Expert;

    }

    public void GoToStart()
    {
        analyticsGraphTab.SetActive(false);
        startMenu.SetActive(true);
    }

    public void OpenSettingsMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void CloseSettingsMenu()
    {
        settingsMenu.SetActive(false);
    }

    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        //crane.StopRotation();
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        //crane.StartRotation();
    }

    public void RestartGame()
    {
        pauseMenu.SetActive(false);
        gameOverScreen.SetActive(false);
        LoadBeginnerLevel();
        //crane.ResetRotation();
        //crane.StartRotation();
    }
    public void ShowLeaderBoard()
    {
        gameOverScreen.SetActive(false);
        leaderBoard.SetActive(true);
    }

    public void ShowAnalyticsStatsTab()
    {
        leaderBoard.SetActive(false);
        analyticsStatsTab.SetActive(true);

    }

    public void ShowAnalyticsGraphTab()
    {
        analyticsStatsTab.SetActive(false);
        analyticsGraphTab.SetActive(true);
    }

    public void ShowGameOver()
    {
        gameOverScreen.SetActive(true);
        //gameManager.sessionEnded = true;
    }


}


