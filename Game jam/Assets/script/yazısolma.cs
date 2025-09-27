using UnityEngine;
using TMPro;
using System.Collections;

public class TextFadeOut : MonoBehaviour
{
    public float fadeDuration = 2.0f; // Solma süresi
    public float startDelay = 0.0f; // Başlama gecikmesi
    
    private TextMeshProUGUI textMesh;
    
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        StartCoroutine(FadeOutCoroutine());
    }
    
    IEnumerator FadeOutCoroutine()
    {
        // Gecikme
        yield return new WaitForSeconds(startDelay);
        
        float timer = 0f;
        Color originalColor = textMesh.color;
        
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            
            Color newColor = originalColor;
            newColor.a = alpha;
            textMesh.color = newColor;
            
            yield return null;
        }
        
        // Tamamen görünmez yap
        Color finalColor = textMesh.color;
        finalColor.a = 0f;
        textMesh.color = finalColor;
        
        // Objeyi gizle (opsiyonel)
        // gameObject.SetActive(false);
    }
}