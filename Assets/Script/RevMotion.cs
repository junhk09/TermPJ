using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float revSpeed;//����
    public float rotSpeed;//����

    public GameObject planet;

    public void Rotate()
    {

        transform.RotateAround(planet.transform.position, Vector3.up, Time.deltaTime * revSpeed * 1.0f);

        //����
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime * 5.0f);
    }
}
