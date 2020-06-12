using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff_Control_Goddes : MonoBehaviour
{
    Rigidbody2D Buff_rb;
    Vector2 Throw_Direction;

    public Sprite Yellow;
    public Sprite Green;
    private SpriteRenderer Buff_SR;
    // Start is called before the first frame update
    void Start()
    {
        Buff_rb = GetComponent<Rigidbody2D>();
        WhichBuff();
        Launch();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Launch()
    {

        switch (Random.Range(1, 7))
        {
            case 1:
                Throw_Direction.Set(7500, 2300);
                break;
            case 2:
                Throw_Direction.Set(8000, 2050);
                break;
            case 3:
                Throw_Direction.Set(9000, 2200);
                break;
            case 4:
                Throw_Direction.Set(3000, 1000);
                break;
            case 5:
                Throw_Direction.Set(4000, 1200);
                break;
            case 6:
                Throw_Direction.Set(2700, 1000);
                break;
            default:
                Throw_Direction.Set(6400, 1000);
                break;
        }
        Buff_rb.AddForce(Throw_Direction);
    }
    void WhichBuff()
    {
        Buff_SR = GetComponent<SpriteRenderer>();
        switch (Random.Range(1, 3))
        {
            case 1:
                Buff_SR.sprite = Yellow;
                gameObject.tag = "ArmorBuff";
                break;
            case 2:
                Buff_SR.sprite = Green;
                gameObject.tag = "HealthBuff";
                break;
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerStats")
        {
            Destroy(gameObject);
        }
    }
}