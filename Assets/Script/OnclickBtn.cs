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
        Debug.Log("Button Clicked");
    }
    public void OnClickVenus()
    {
        SceneManager.LoadScene("Venus");
        Debug.Log("Button Clicked");
    }

    public void OnClickEarth()
    {
        SceneManager.LoadScene("Earth");
        Debug.Log("Button Clicked");
    }

    public void OnClickMars()
    {
        SceneManager.LoadScene("Mars");
        Debug.Log("Button Clicked");
    }

    public void OnClickJupiter()
    {
        SceneManager.LoadScene("Jupiter");
        Debug.Log("Button Clicked");
    }

    public void OnClickSaturn()
    {
        SceneManager.LoadScene("Saturn");
        Debug.Log("Button Clicked");
    }

    public void OnClickUranus()
    {
        SceneManager.LoadScene("Uranus");
        Debug.Log("Button Clicked");
    }

    public void OnClickNeptune()
    {
        SceneManager.LoadScene("Neptune");
        Debug.Log("Button Clicked");
    }
}
