using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rotate : MonoBehaviour
{
    
    public float speed = 10.0f;        
    private void Update()
    {
        Orbit_Rotation();
    }

    void Orbit_Rotation()
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
      
    }
    

    

}
