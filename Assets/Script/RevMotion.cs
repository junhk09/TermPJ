using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float revSpeed;//공전
    public float rotSpeed;//자전

    public GameObject planet;

    public void Rotate()
    {

        transform.RotateAround(planet.transform.position, Vector3.up, Time.deltaTime * revSpeed * 1.0f);

        //자전
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime * 5.0f);
    }
}
