using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToSolar : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickExitBtn()
    {
        SceneManager.LoadScene("SolarSystem");
       
    }
}
