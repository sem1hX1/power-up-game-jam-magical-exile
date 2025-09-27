using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CikisButonuFade : MonoBehaviour
{
    public Button cikisButonu;
    public CanvasGroup menuCanvas;
    public float fadeSuresi = 1.0f;

    void Start()
    {
        cikisButonu.onClick.AddListener(CikisYap);
    }

    void CikisYap()
    {
        StartCoroutine(FadeVeCikis());
    }

    IEnumerator FadeVeCikis()
    {
        // Butonu devre dışı bırak
        cikisButonu.interactable = false;

        // Menüyü yavaşça soldur
        float sayac = 0f;
        while (sayac < fadeSuresi)
        {
            sayac += Time.deltaTime;
            menuCanvas.alpha = 1f - (sayac / fadeSuresi);
            yield return null;
        }

        // Oyunu kapat
        Debug.Log("Oyun kapatılıyor...");
        
        Application.Quit();
        
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}