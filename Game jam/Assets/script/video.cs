using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class BackgroundVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage videoDisplay;
    public RenderTexture videoTexture;

    void Start()
    {
        // Video hazır olduğunda oynat
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        // Render Texture'ü RawImage'e bağla
        videoDisplay.texture = videoTexture;
        
        // Videoyu oynat
        videoPlayer.Play();
        Debug.Log("Arka plan videosu başladı!");
    }

    void Update()
    {
        // Video döngüsünü kontrol et (güvenlik için)
        if (!videoPlayer.isPlaying && videoPlayer.isPrepared)
        {
            videoPlayer.Play();
        }
    }

    void OnDestroy()
    {
        // Temizlik
        if (videoPlayer != null)
            videoPlayer.Stop();
    }
}