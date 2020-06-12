using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudControl : MonoBehaviour
{
    public Sprite Cloud1;
    public Sprite Cloud2;
    public Sprite Cloud3;

    SpriteRenderer CloudSpriteRenderer;
    Vector3 Cloud_New_Pos;
    // Start is called before the first frame update
    void Start()
    {
        CloudSpriteRenderer = GetComponent<SpriteRenderer>();
        switch (Random.Range(1, 4)) // Decides randomly which Sprit will be used.
        {
           case 1:
                CloudSpriteRenderer.sprite = Cloud1;
                break;
            case 2:
                CloudSpriteRenderer.sprite = Cloud2;
                break;
            case 3:
                CloudSpriteRenderer.sprite = Cloud3;
                break;
        }
    }

    private void OnBecameInvisible()
    {
        transform.position =  new Vector3(Random.Range(Camera.main.transform.position.x + 768, Camera.main.transform.position.x + 968), Random.Range(200, 250), 1);
    }
}
