using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public sbyte Health = 3; // player has 3 life. He loses 1 for every hit.com
    public int Dmg = 1;
    public float Fire_Rate = 0.5f;
    public bool Armor = false; // protecs from 1 hit.
    public float Speed = 250.0f;

    public Sprite Full_HealthBar;
    public Sprite Two_HealthBar;
    public Sprite One_HealthBar;
    public Sprite Empty_HealthBar;
    private SpriteRenderer HealthBar_SR;
    private void Start()
    {
        HealthBar_SR = GetComponent<SpriteRenderer>();
        HealthBar_SR.sprite = Full_HealthBar;
    }
    void Update()
    {
        switch (Health)
        {
            case 0:
                HealthBar_SR.sprite = Empty_HealthBar;
                Destroy(transform.parent.gameObject, 2.0f);
                break;
            case 1:
                HealthBar_SR.sprite = One_HealthBar;
                break;
            case 2:
                HealthBar_SR.sprite = Two_HealthBar;
                break;
            case 3:
                HealthBar_SR.sprite = Full_HealthBar;
                break;
            default:
                HealthBar_SR.sprite = Empty_HealthBar;
                Destroy(transform.parent.gameObject, 2.0f);
                break;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "EnemyProjectile":
                if (Armor == false)
                {
                    Health--;
                    switch (Health)
                    {
                        case 0:
                            HealthBar_SR.sprite = Empty_HealthBar;
                            Destroy(transform.parent.gameObject, 2.0f);
                            break;
                        case 1:
                            HealthBar_SR.sprite = One_HealthBar;
                            break;
                        case 2:
                            HealthBar_SR.sprite = Two_HealthBar;
                            break;
                        case 3:
                            HealthBar_SR.sprite = Full_HealthBar;
                            break;
                        default:
                            HealthBar_SR.sprite = Empty_HealthBar;
                            Destroy(transform.parent.gameObject, 2.0f);
                            break;
                    }
                }
                if (Armor == true)
                {
                    Armor = false;
                }
                break;
            case "ArmorBuff":
                Armor = true;
                break;
            case "HealthBuff":
                if (Health < 3)
                {
                    Health++;
                    switch (Health)
                    {
                        case 0:
                            HealthBar_SR.sprite = Empty_HealthBar;
                            Destroy(transform.parent.gameObject, 2.0f);
                            break;
                        case 1:
                            HealthBar_SR.sprite = One_HealthBar;
                            break;
                        case 2:
                            HealthBar_SR.sprite = Two_HealthBar;
                            break;
                        case 3:
                            HealthBar_SR.sprite = Full_HealthBar;
                            break;
                        default:
                            HealthBar_SR.sprite = Empty_HealthBar;
                            Destroy(transform.parent.gameObject, 2.0f);
                            break;
                    }
                }
                break;
            case "DmgBuff":
                Dmg++;
                break;
            case "SpeedBuff":
                Speed = 500;
                Invoke("ResetSpeed", 8.0f);
                break;
            case "FireRateBuff":
                Fire_Rate = 0.25f;
                Invoke("ResetFireRate", 7.0f);
                break;

        }
    }
    void ResetSpeed()
    {
        Speed = 250.0f;
    }
    void ResetFireRate()
    {
        Fire_Rate = 0.5f;
    }
}
