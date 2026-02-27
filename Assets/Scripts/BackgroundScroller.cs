using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 0.5f;
    private Renderer rend;

    void Start() => rend = GetComponent<Renderer>();
    void Update() => rend.material.mainTextureOffset = new Vector2(0, -Time.time * speed);
}
