using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Statik bir referans, bu objenin bir kopyasının zaten var olup olmadığını kontrol etmek için kullanılır.
    private static MusicPlayer instance = null;

    // "Awake" metodu, Start'tan bile önce, obje oluşturulur oluşturulmaz çağrılır.
    void Awake()
    {
        // 1. Kontrol: Zaten bir MusicPlayer örneği var mı?
        if (instance == null)
        {
            // Eğer yoksa, bu objeyi (yani müziği) örnek olarak ayarla.
            instance = this;
            
            // 2. ÖNEMLİ KOMUT: Sahne değiştiğinde bu objeyi yok etme.
            DontDestroyOnLoad(this.gameObject);
            
            Debug.Log("Müzik çalar başlatıldı ve sahne geçişinde korunacak.");
        }
        else
        {
            // Eğer zaten bir MusicPlayer örneği varsa,
            // bu yeni kopyayı yok et (ikiz müzik çalmayı engeller).
            Destroy(gameObject);
            Debug.LogWarning("Müzik çaların ikinci kopyası tespit edildi ve yok edildi.");
        }
    }
}