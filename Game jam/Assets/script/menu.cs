using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Button startButton;

    void Start()
    {
        // Buton tıklanınca Intro sahnesine geç
        startButton.onClick.AddListener(GoToIntro);
    }

    void GoToIntro()
    {
        // Build Settings'teki 2. sahneye geç (Intro)
        SceneManager.LoadScene(2);
    }
}