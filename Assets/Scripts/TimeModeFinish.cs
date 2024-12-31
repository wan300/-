using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeModeFinish : MonoBehaviour
{
    public static string currentScene;    // 当前场景索引
    public static float pauseCountdownTime; // 暂停时的倒计时时间
    public static int currentScore;         // 当前分数

    public static bool IsTimeMode;
    void Start()
    {
        // 初始化时获取当前场景索引
        currentScene = SceneManager.GetActiveScene().name;
    }

    // 这个方法将由UI按钮的OnClick事件调用
    public void OnPauseButtonClicked()
    {
        IsTimeMode = true;
        PauseGame();
    }

    private void PauseGame()
    {
        // 记录当前分数
        currentScore = ScoreManager.score;
        Debug.Log("Current Score: " + currentScore);

        // 记录当前场景索引
        Debug.Log("Current Scene Index: " + currentScene);

        // 记录暂停时的倒计时时间
        pauseCountdownTime = TimeManager.countdownTime;
        Debug.Log("Pause Countdown Time: " + pauseCountdownTime);
       
        

        // 跳转到暂停场景
        SceneManager.LoadScene("PauseScene");


    }
}
