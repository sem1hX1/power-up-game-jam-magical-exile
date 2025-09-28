using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Button startButton;

    void Start()
    {
        
    }

    public void GoToIntro()
    {
        // Build Settings'teki 2. sahneye geç (Intro)
        SceneManager.LoadScene(2);
    }
}