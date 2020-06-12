using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeEnemyControl : MonoBehaviour
{
    private sbyte Enemy_Health = 1;
    private sbyte Enemy_Speed;
    private string Enemy_Tag;

    Rigidbody2D Enemy_rb;
    Vector2 Enemy_Pos;

    public GameObject Enemy_Projectile;

    // Start is called before the first frame update
    void Start()
    {
        Enemy_rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Launch_Projectile", 1.0f, 5.0f);
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
    void Launch_Projectile()
    {
        GameObject Buff = Instantiate(Enemy_Projectile, transform.position + new Vector3(-50, 0, 0), Quaternion.identity);
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
