using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float scrollspeed = 0.5f;

    private float offset;
    private Material backgraundmaterial;


    void Start()
    {
        backgraundmaterial = GetComponent<Renderer>().material;
    }
    void Update()
    {
        offset += scrollspeed * Time.deltaTime;

        backgraundmaterial.SetTextureOffset("_MainTex", new Vector2(offset,0));
    }
}
