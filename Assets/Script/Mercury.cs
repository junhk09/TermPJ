using System.Collections;
using System.Collections.Generic;
using Unity.VRTemplate;
using UnityEngine;

public class Mercury : MonoBehaviour
{
    public GameObject HeartGroup;
   
    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "item")
        {
            Destroy(other.gameObject);
            HeartGroup.SetActive(true);
        }
    }
    public void CloseBtn()
    {
        HeartGroup.SetActive(false);
    }
}
