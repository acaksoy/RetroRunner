using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControl : MonoBehaviour
{
    public Sprite Tower1;
    public Sprite Tower2;
    public Sprite Tower3;
    public Sprite Tower4;
    public Sprite Tower5;
    public Sprite long_comb_2;
    public Sprite wide_comb_2;
    public Sprite long_comb_3;
    public Sprite Külliye;
    public Sprite wide_Tower1;
    public Sprite wide_Tower2;
    public Sprite wide_Tower3;
    public Sprite wide_Tower4;

    SpriteRenderer TowerSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        TowerSpriteRenderer = GetComponent<SpriteRenderer>();
        switch (Random.Range(1, 14)) // Decides randomly which Sprit will be used.
        {
            case 1:
                TowerSpriteRenderer.sprite = Tower1;
                CounterSingleton.Width_Tower = 68;
                break;
            case 2:
                TowerSpriteRenderer.sprite = Tower2;
                CounterSingleton.Width_Tower = 95;
                break;
            case 3:
                TowerSpriteRenderer.sprite = Tower3;
                CounterSingleton.Width_Tower = 54;
                break;
            case 4:
                TowerSpriteRenderer.sprite = Tower4;
                CounterSingleton.Width_Tower = 35;
                break;
            case 5:
                TowerSpriteRenderer.sprite = Tower5;
                CounterSingleton.Width_Tower = 64;
                break;
            case 6:
                TowerSpriteRenderer.sprite = long_comb_2;
                CounterSingleton.Width_Tower = 98;
                break;
            case 7:
                TowerSpriteRenderer.sprite = wide_comb_2;
                CounterSingleton.Width_Tower = 244;
                break;
            case 8:
                TowerSpriteRenderer.sprite = long_comb_3;
                CounterSingleton.Width_Tower = 230;
                break;
            case 9:
                TowerSpriteRenderer.sprite = Külliye;
                CounterSingleton.Width_Tower = 519;
                break;
            case 10:
                TowerSpriteRenderer.sprite = wide_Tower1;
                CounterSingleton.Width_Tower = 167;
                break;
            case 11:
                TowerSpriteRenderer.sprite = wide_Tower2;
                CounterSingleton.Width_Tower = 323;
                break;
            case 12:
                TowerSpriteRenderer.sprite = wide_Tower3;
                CounterSingleton.Width_Tower = 148;
                break;
            case 13:
                TowerSpriteRenderer.sprite = wide_Tower4;
                CounterSingleton.Width_Tower = 150;
                break;

        }
    }

    private void OnBecameInvisible()
    {
        //CounterSingleton.Instance.DecreaseCounter();
        CounterSingleton.Tower_Counter--;
        Destroy(gameObject);
    }
}
