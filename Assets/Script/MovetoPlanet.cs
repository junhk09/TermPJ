using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovetoPlanet : MonoBehaviour
{
    // 이동할 Scene의 이름을 변수로 지정
    [SerializeField]
    private string targetScene;

    // GameObject가 클릭되었을 때 호출
    private void OnMouseDown()
    {
        // targetScene 이름으로 Scene 전환
        if (!string.IsNullOrEmpty(targetScene))
        {
            SceneManager.LoadScene(targetScene);
        }
        else
        {
            Debug.LogError("Target scene name is not set.");
        }
    }
}
