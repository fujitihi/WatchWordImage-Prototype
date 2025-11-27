using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeKeyHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Home");
        }
    }
}
