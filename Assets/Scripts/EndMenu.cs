using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndMenu : MonoBehaviour
{

   public void ReloadGame(){
    ScoreManager.score = 0;
       
   if(SceneManager.GetActiveScene().name == "End 1"||StartCheckFinish.IsfinishGame){
        SceneManager.LoadScene("Start 1");
         
         
   }else{
    SceneManager.LoadScene("Start");
   }
      
   }
}
