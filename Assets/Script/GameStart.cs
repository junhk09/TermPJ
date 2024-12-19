using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject StartGroup;
    public GameObject ExplainGroup;
    
    public void play()
    {
        SceneManager.LoadScene("SolarSystem");
    }
   public void ExplainBtn()
    {
        StartGroup.SetActive(false);
        ExplainGroup.SetActive(true);
    }
    public void ExitBtn()
    {
        StartGroup.SetActive(true);
        ExplainGroup.SetActive(false);
    }
    public void MiniGame()
    {
        StartGroup.SetActive(false);
        ExplainGroup.SetActive(false);
    }
}
