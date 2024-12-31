using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public ScoreManager scoreManager; // 引用分数管理器
    public TimeManager timeManager;   // 引用时间管理器

   public void ContinueGame()
    {
        // 恢复分数
        
  
        ScoreManager.score = NormalModeFinish.currentScore;
        Debug.Log("Restored Score: " + ScoreManager.score);

        // 恢复倒计时时间
        timeManager.currentTime = NormalModeFinish.pauseCountdownTime;
        Debug.Log("Restored Countdown Time: " + timeManager.currentTime.ToString("F2") + " seconds");

        // 跳转到之前的场景
        SceneManager.LoadScene( NormalModeFinish.currentScene);
    }
 
}