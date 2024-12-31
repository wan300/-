using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartRankingScene(){
       SceneManager.LoadScene("Ranking");
   }
}
