using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float revSpeed;//공전
    public float rotSpeed;//자전

    public GameObject planet;

    // Update is called once per frame
    void Update()
    {
        //공전
        transform.RotateAround(planet.transform.position, Vector3.up, Time.deltaTime * revSpeed * 1.0f);

        //자전
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime * 1.0f);
    }
}
