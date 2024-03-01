using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pop_the_inventory : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isOverlayActive = false;

    void Update()
    {
        // ��ư�� ������ �� ���� �ε��մϴ�.
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!isOverlayActive)
            {
                LoadOverlayScene();
            }
            else
            {
                UnloadOverlayScene();
            }
        }
    }

    void LoadOverlayScene()
    {
        // ���� �� ���� ���ο� ���� �ε��մϴ�.
        UnityEngine.SceneManagement.SceneManager.LoadScene("Canvas", LoadSceneMode.Additive);
        isOverlayActive = true;
    }

    void UnloadOverlayScene()
    {
        // ���ο� ���� ��ε��մϴ�.
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("Canvas");
        isOverlayActive = false;
    }

}
