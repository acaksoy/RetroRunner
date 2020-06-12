using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChildController : MonoBehaviour
{
    Collider2D EnemyChild_collider;
    // Start is called before the first frame update
    void Start()
    {
        EnemyChild_collider = GetComponent<Collider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyChild_collider.enabled == false)
        {
            Invoke("ReactivateCollider", 2.0f);
        }
       
    }
    void ReactivateCollider()
    {
        EnemyChild_collider.enabled = true;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyChild_collider.enabled = false;
        collision.gameObject.GetComponentInParent<Rigidbody2D>().AddForce(new Vector2(-500000, 0));
        if (collision.gameObject.GetComponentInChildren<PlayerStats>().Armor)
        {
            collision.gameObject.GetComponentInChildren<PlayerStats>().Armor = false;
        }
        else
        {
            collision.gameObject.GetComponentInChildren<PlayerStats>().Health--;
        }
        
    }
}
