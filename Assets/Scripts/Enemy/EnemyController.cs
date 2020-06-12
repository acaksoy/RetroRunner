using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private sbyte Enemy_Health = 1;
    private sbyte Enemy_Speed;
    private string Enemy_Tag;

    Rigidbody2D Enemy_rb;
    Vector2 Enemy_Pos;

    // Start is called before the first frame update
    void Start()
    {
        Enemy_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy_Pos = Enemy_rb.position;
        Enemy_Pos.x = Enemy_Pos.x - Time.deltaTime * Enemy_Speed;
        Enemy_rb.MovePosition(Enemy_Pos);

        if (Enemy_Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void SetEnemy(sbyte Health, sbyte Speed, string Tag)
    {
        Enemy_Health = Health;
        Enemy_Speed = Speed;
        Enemy_Tag = Tag;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Enemy_Health--;
        }
    }
}
