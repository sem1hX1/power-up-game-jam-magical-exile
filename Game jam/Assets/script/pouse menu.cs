using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SimplePauseSystem : MonoBehaviour
{
    public Button pauseButton;
    public GameObject pausePanel;
    public Button resumeButton;
    public Button quitButton;
    
    private bool gamePaused = false;

    void Start()
    {
        // Buton eventlerini bağla
        pauseButton.onClick.AddListener(TogglePause);
        resumeButton.onClick.AddListener(ResumeGame);
        quitButton.onClick.AddListener(QuitGame);
        
        // Başlangıç ayarları
        if (pausePanel != null)
            pausePanel.SetActive(false);
            
        Debug.Log("Pause sistemi hazır");
    }

    void TogglePause()
    {
        gamePaused = !gamePaused;
        
        Time.timeScale = gamePaused ? 0f : 1f;
        if (pausePanel != null)
            pausePanel.SetActive(gamePaused);
            
        UpdatePauseButton();
        Debug.Log("Oyun durduruldu: " + gamePaused);
    }

    void ResumeGame()
    {
        gamePaused = false;
        Time.timeScale = 1f;
        if (pausePanel != null)
            pausePanel.SetActive(false);
            
        UpdatePauseButton();
        Debug.Log("Oyun devam ediyor");
    }

    void QuitGame()
    {
        Debug.Log("Çıkış butonuna tıklandı!");
        
        // Önce oyunu devam ettir
        Time.timeScale = 1f;
        
        // 1. SEÇENEK: Ana menüye dön
        // SceneManager.LoadScene(0); // Build index ile
        // Veya: SceneManager.LoadScene("AnaMenu"); // İsim ile
        
        // 2. SEÇENEK: Oyunu tamamen kapat
        Application.Quit();
        
        // Editörde test için
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    
    void UpdatePauseButton()
    {
        if (pauseButton != null)
        {
            Text buttonText = pauseButton.GetComponentInChildren<Text>();
            if (buttonText != null)
            {
                buttonText.text = gamePaused ? "▶" : "⏸️";
            }
        }
    }
}