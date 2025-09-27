using UnityEngine;
using TMPro;

public class VerticalScrollingText : MonoBehaviour
{
    public float speed = 50f; // yazının kayma hızı
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Sürekli yukarı kaydır - hiç durmadan ve başa dönmeden
        rectTransform.anchoredPosition += Vector2.up * speed * Time.deltaTime;
        
        // Not: Yazı ekranın dışına çıksa bile kaymaya devam edecek
    }
}