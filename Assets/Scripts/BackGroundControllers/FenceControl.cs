using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceControl : MonoBehaviour
{
    public Sprite Fence_Sprite;
    private BoxCollider2D FenceCollider2D;
    Vector2 FenceColliderOffset = new Vector2(640, 26); // Center of Sprite
    Vector2 FenceColliderSize = new Vector2(1280, 53); // Size of Sprite

    SpriteRenderer TowerSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        TowerSpriteRenderer = GetComponent<SpriteRenderer>();
        TowerSpriteRenderer.sprite = Fence_Sprite;
        FenceCollider2D = GetComponent<BoxCollider2D>();
        FenceCollider2D.offset = FenceColliderOffset; // Center of Sprite
        FenceCollider2D.size = FenceColliderSize; // Widht of Sprite
        
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(Camera.main.transform.position.x + 640.0f, -167.0f, 1);
    }
}
