using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileController : MonoBehaviour
{
    Rigidbody2D Buff_rb;
    Vector2 Throw_Direction;
    private float Force = 10000.0f;

    // Start is called before the first frame update
    void Start()
    {
        Buff_rb = GetComponent<Rigidbody2D>();
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
                Throw_Direction.Set(-1, 0.5f);
                break;
            case 2:
                Throw_Direction.Set(-2, 0.5f);
                break;
            case 3:
                Throw_Direction.Set(-1, 0.5f);
                break;
            case 4:
                Throw_Direction.Set(-3, 0.5f);
                break;
            case 5:
                Throw_Direction.Set(-1, -0.5f);
                break;
            case 6:
                Throw_Direction.Set(-2, 0.5f);
                break;
            default:
                Throw_Direction.Set(-3, -0.5f);
                break;
        }
        Buff_rb.AddForce(Throw_Direction * Force);
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
