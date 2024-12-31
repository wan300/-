using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish1 : MonoBehaviour
{
    // 引用ScoreManager对象
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        // 查找并引用场景中的ScoreManager对象
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // 检查分数是否大于一百
        if (scoreManager != null && ScoreManager.score > 750 &&SceneManager.GetActiveScene().name=="Main")
        {
            // 执行后续任务
           ChangeImage1();
        }
        if (scoreManager != null && ScoreManager.score > 1600 && SceneManager.GetActiveScene().name == "Main2")
        {
            // 执行后续任务
           ChangeImage2();
        }
        if (scoreManager != null && ScoreManager.score > 2600 && SceneManager.GetActiveScene().name == "Main3")
        {
            // 执行后续任务
           ChangeImage3();
        }
        if (scoreManager != null && ScoreManager.score > 3700 && SceneManager.GetActiveScene().name == "Main4")
        {
            // 执行后续任务
           ChangeImage4();
        }
        

    }

    /// <summary>
    /// 执行后续任务的函数。
    /// </summary>
    private void ChangeImage1()
    {
        // 在这里编写后续任务的代码
       SceneManager.LoadScene("Main2");
        // 例如：显示胜利界面、播放动画等
    }
    private void ChangeImage2()
    {
        // 在这里编写后续任务的代码
       SceneManager.LoadScene("Main3");
        // 例如：显示胜利界面、播放动画等
    }
    private void ChangeImage3()
    {
        // 在这里编写后续任务的代码
       SceneManager.LoadScene("Main4");
        // 例如：显示胜利界面、播放动画等
    }
    private void ChangeImage4()
    {
        // 在这里编写后续任务的代码
       SceneManager.LoadScene("Main5");
        // 例如：显示胜利界面、播放动画等
    }
    private void ChangeImage5()
    {
        // 在这里编写后续任务的代码
       SceneManager.LoadScene("End 1");
        // 例如：显示胜利界面、播放动画等
    }
}