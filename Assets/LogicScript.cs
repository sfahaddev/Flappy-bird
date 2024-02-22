using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource deadeffect;
    private bool isGameOver = false;
    public GameObject exitButton; // Reference to the ExitButton GameObject




    // Add a Start method to initialize your game.
    void Start()
    {
        
    }

    [ContextMenu("Increase score")]
    public void AddScore(int scoreToAdd)
    {

       
        PlayerScore += scoreToAdd;
            scoreText.text = PlayerScore.ToString();
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        deadeffect.Play();
        ShowExitButton(); // Call the method to show the exit button


    }
    public bool IsGameOver()
    {
        return isGameOver;
    }
    public void ShowExitButton()
    {
        exitButton.SetActive(true); // Show the exit button
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
