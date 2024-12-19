using System.Collections;
using System.Collections.Generic;
using Unity.VRTemplate;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mercury : MonoBehaviour
{
    public GameObject HeartGroup;
    public GameObject HeartUI;
   
    
    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "item")
        {
            Score.Count++;
            Destroy(other.gameObject);
          
        }
        if (Score.Count == 5)
        {
            HeartUI.SetActive(false);
            HeartGroup.SetActive(true);
        }
    }

    public void CloseBtn()
    {
        
        SceneManager.LoadScene("SolarSystem");
    }
}
