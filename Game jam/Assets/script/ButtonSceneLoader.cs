using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    // Bu fonksiyonu doğrudan buton event'ine bağlayabilirsin
    public void OnButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}