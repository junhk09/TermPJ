using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnclickBtn : MonoBehaviour
{   
    public void OnClickMiniGame()
    {
        SceneManager.LoadScene("Mini Game");
    }
    public void OnClickMercury()
    {
        SceneManager.LoadScene("Mercury");
        
    }
    public void OnClickVenus()
    {
        SceneManager.LoadScene("Venus");
      
    }

    public void OnClickEarth()
    {
        SceneManager.LoadScene("Earth");
       
    }

    public void OnClickMars()
    {
        SceneManager.LoadScene("Mars");
       
    }

    public void OnClickJupiter()
    {
        SceneManager.LoadScene("Jupiter");
      
    }

    public void OnClickSaturn()
    {
        SceneManager.LoadScene("Saturn");
     
    }

    public void OnClickUranus()
    {
        SceneManager.LoadScene("Uranus");
        
    }

    public void OnClickNeptune()
    {
        SceneManager.LoadScene("Neptune");
        
    }
}
