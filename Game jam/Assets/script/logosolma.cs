using UnityEngine;
using UnityEngine.UI; // UI elemanlarına erişmek için gerekli

public class FadeOutLogo : MonoBehaviour
{
    public float fadeDuration = 2.0f; // Solma süresi (saniye cinsinden)
    private Image logoImage; // Logo görselimizin referansı
    private float currentAlpha; // Mevcut saydamlık değeri

    void Start()
    {
        // GameObject üzerindeki Image bileşenini al
        logoImage = GetComponent<Image>();

        // Başlangıçta tam görünür olmalı (alpha = 1)
        currentAlpha = logoImage.color.a;

        // Solma işlemini başlat
        StartCoroutine(FadeOut());
    }

    System.Collections.IEnumerator FadeOut()
    {
        float startAlpha = currentAlpha;
        float timer = 0f;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime; // Geçen zamanı ekle
            // Saydamlık değerini doğrusal olarak azalt
            currentAlpha = Mathf.Lerp(startAlpha, 0f, timer / fadeDuration);

            // Yeni rengi uygula (mevcut rengin sadece alpha değerini değiştir)
            Color newColor = logoImage.color;
            newColor.a = currentAlpha;
            logoImage.color = newColor;

            yield return null; // Bir sonraki frame'e kadar bekle
        }

        // Solma tamamlandığında tamamen şeffaf yap
        Color finalColor = logoImage.color;
        finalColor.a = 0f;
        logoImage.color = finalColor;

        // İsteğe bağlı: Logo tamamen kaybolduktan sonra GameObject'i devre dışı bırak
        // gameObject.SetActive(false);
        // Veya sahneden kaldır:
        // Destroy(gameObject);
    }
}