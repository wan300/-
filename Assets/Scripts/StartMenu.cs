using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        ScoreManager.score = 0;
        //Start the game
        SceneManager.LoadScene("Main");
    }
    void Start()
    {
        //ScoreManager.score = 0;
    }
}
