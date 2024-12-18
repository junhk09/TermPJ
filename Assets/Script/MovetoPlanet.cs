using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovetoPlanet : MonoBehaviour
{
    // �̵��� Scene�� �̸��� ������ ����
    [SerializeField]
    private string targetScene;

    // GameObject�� Ŭ���Ǿ��� �� ȣ��
    private void OnMouseDown()
    {
        // targetScene �̸����� Scene ��ȯ
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
