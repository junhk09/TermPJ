using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float revSpeed;//����
    public float rotSpeed;//����

    public GameObject planet;

    // Update is called once per frame
    void Update()
    {
        //����
        transform.RotateAround(planet.transform.position, Vector3.up, Time.deltaTime * revSpeed * 1.0f);

        //����
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime * 1.0f);
    }
}
