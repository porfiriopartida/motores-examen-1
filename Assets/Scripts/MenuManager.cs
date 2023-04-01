using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public Button playButton;
    public Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(PlayPressed);
        quitButton.onClick.AddListener(ExitPressed);
    }

    private static void PlayPressed()
    {
        SceneManager.LoadScene(1);
    }
    
    private static void ExitPressed()
    {
        Debug.Log("Exit pressed");
        Application.Quit(0);
    }
}
