using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeGame : MonoBehaviour
{
   

    // 这个方法将由UI按钮的OnClick事件调用
    public void OnResumeButtonClicked()
    {   
        if (TimeModeFinish.IsTimeMode)
        {
            ResumeTimeGameFromPause();
        }
        else
        ResumeNormalGameFromPause();
    }

    private void ResumeNormalGameFromPause()
    {
        // 检查scoreManager和timeManager是否已正确引用
       

        // 恢复暂停前的分数
        ScoreManager.score = NormalModeFinish.currentScore;
        Debug.Log("Resumed Score: " + NormalModeFinish.currentScore);

       
       
        // 跳转回暂停前的场景
        SceneManager.LoadScene(NormalModeFinish.currentScene);
    }
    private void ResumeTimeGameFromPause(){
         // 恢复暂停前的分数
        ScoreManager.score = TimeModeFinish.currentScore;
        Debug.Log("Resumed Score: " + TimeModeFinish.currentScore);

        // 恢复暂停前的时间
        TimeManager.countdownTime = TimeModeFinish.pauseCountdownTime;
        TimeManager.ispause = true;
        // 跳转回暂停前的场景
        SceneManager.LoadScene(TimeModeFinish.currentScene);

        // 重置TimeModeFinish的标志
        TimeModeFinish.IsTimeMode = false;
    }

}
