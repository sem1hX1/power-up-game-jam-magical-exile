using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Fade Settings")]
    public float fadeDuration = 2.0f;
    
    [Header("UI Elements")]
    public CanvasGroup logoCanvasGroup;
    public CanvasGroup teamNameCanvasGroup;
    
    void Start()
    {
        StartCoroutine(FadeAndLoadScene());
    }
    
    IEnumerator FadeAndLoadScene()
    {
        yield return new WaitForSeconds(1.0f);
        
        float elapsedTime = 0f;
        
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            
            if (logoCanvasGroup != null)
                logoCanvasGroup.alpha = alpha;
                
            if (teamNameCanvasGroup != null)
                teamNameCanvasGroup.alpha = alpha;
            
            yield return null;
        }
        
        if (logoCanvasGroup != null)
            logoCanvasGroup.alpha = 0f;
            
        if (teamNameCanvasGroup != null)
            teamNameCanvasGroup.alpha = 0f;
        
        // DÜZELTME: 2. sahneye (Intro'ya) geç
        SceneManager.LoadScene(1);
    }
}