using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour
{
    public static SceneManagerController Instance = null;
    private void Start()
    {
        if (Instance == null) {
            Instance = this;
        }
    }

    public void Win(string nextScene)
    {
        LoadScene(nextScene);
    }

    public void Restart()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void LoadScene(string sceneName) =>
        SceneManager.LoadScene(sceneName);
    public void LoadScene(int idx) =>
        SceneManager.LoadScene(idx);
}