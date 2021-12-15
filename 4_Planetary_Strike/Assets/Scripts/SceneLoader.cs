using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        Invoke("LoadFirstScene", 5f);
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
