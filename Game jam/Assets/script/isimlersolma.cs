using UnityEngine;
using TMPro;
using System.Collections;

public class FadeOutText : MonoBehaviour
{
    public float fadeDuration = 3.0f;
    public float startDelay = 1.0f; // Başlamadan önce bekleme süresi
    private TextMeshProUGUI textComponent;

    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        // Başlamadan önce bekle
        yield return new WaitForSeconds(startDelay);

        float startAlpha = textComponent.color.a;
        float timer = 0f;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float currentAlpha = Mathf.Lerp(startAlpha, 0f, timer / fadeDuration);
            
            Color newColor = textComponent.color;
            newColor.a = currentAlpha;
            textComponent.color = newColor;

            yield return null;
        }

        // Objeyi gizle
        gameObject.SetActive(false);
    }
}