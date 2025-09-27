using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public CanvasGroup blackScreen;
    public float fadeTime = 2f;
    
    void Start()
    {
        StartCoroutine(FadeOut());
    }
    
    IEnumerator FadeOut()
    {
        // 1 saniye siyah ekran kalsın
        yield return new WaitForSeconds(1f);
        
        // Yavaşça transparan yap
        for(float i = 0; i < fadeTime; i += Time.deltaTime)
        {
            blackScreen.alpha = 1f - (i / fadeTime);
            yield return null;
        }
        
        // Tamamen görünmez yap
        blackScreen.alpha = 0f;
        
        // Sonraki sahneye geç
        SceneManager.LoadScene(1);
    }
}