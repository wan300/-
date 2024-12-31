using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// 管理游戏得分的类。
/// </summary>
public class ScoreManager : MonoBehaviour {

    /// <summary>
    /// 引用游戏中的棋盘对象。
    /// </summary>
    private Board board;
    
    /// <summary>
    /// 显示当前得分的文本对象。
    /// </summary>
    public Text scoreText;
    
    /// <summary>
    /// 当前游戏得分。
    /// </summary>
    public static int score;
    
    /// <summary>
    /// 显示得分进度的图像对象。
    /// </summary>
    public Image scoreBar;

    /// <summary>
    /// 初始化ScoreManager对象。
    /// </summary>
    void Start () {
        // 查找并引用场景中的Board对象。
        
        board = FindObjectOfType<Board>();
        // 初始化时更新得分进度条。
        UpdateBar();
    }
	
    /// <summary>
    /// 每帧更新得分显示。
    /// </summary>
    void Update () {
        // 将当前得分更新到显示文本中。
        scoreText.text = "" + score;
    }

    /// <summary>
    /// 增加得分。
    /// </summary>
    /// <param name="amountToIncrease">增加的得分量。</param>
    public void IncreaseScore(int amountToIncrease)
	{
        // 增加当前得分并更新得分进度条。
        score += amountToIncrease;
        UpdateBar();
    }

    /// <summary>
    /// 更新得分进度条的填充量。
    /// </summary>
    private void UpdateBar()
	{
        // 确保board和scoreBar对象已被正确引用。
        if (board != null && scoreBar != null)
        {
            // 获取得分目标数组的长度。
            int length = board.scoreGoals.Length;
            // 根据当前得分和最高得分目标，计算并设置得分进度条的填充量。
            scoreBar.fillAmount = (float)score / (float)board.scoreGoals[length - 1];
        }
    }
}