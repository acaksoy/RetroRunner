using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Player Movement //
    Rigidbody2D rb_Player;
    float coord_X; // Moves Player in X Coord
    float coord_Y; // Moves Player in Y Coord
    Vector2 new_player_position; // Stores and sets new position of player
    // Player Moverment //

    // Fire Mechanism //
    public GameObject Projectile_Prefab;
    Vector2 lookDirection = new Vector2(1, 0); // Players looking direction.
    Vector2 mouse_Pos;
    // Fire Mechanism //

    // Player Stats//
    PlayerStats Player_Stats;
    private int Player_Accuary = 85;
    private float FireRate = 0.5f;
    // Player Stats//

    // Start is called before the first frame update
    void Start()
    {
        rb_Player = GetComponent<Rigidbody2D>();
        Player_Stats = GetComponentInChildren<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player Moves //
        coord_X = Input.GetAxis("Horizontal");
        coord_Y = Input.GetAxis("Vertical");
        new_player_position = rb_Player.position;
        new_player_position.x += Player_Stats.Speed * coord_X * Time.deltaTime;
        new_player_position.y += Player_Stats.Speed * coord_Y * Time.deltaTime;
        rb_Player.MovePosition(new_player_position);
        // Player Moves //

        // Player Fires //
        if (Input.GetButton("Fire1") && (FireRate >= Player_Stats.Fire_Rate))
        {
            mouse_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Launch_Projectile();
            FireRate = 0;
        }
        FireRate += Time.deltaTime;
        // Player Fires //



    }

    void Launch_Projectile()
    {
        GameObject Projectile = Instantiate(Projectile_Prefab, rb_Player.transform.position + new Vector3(67, 84, 1), Quaternion.identity);
        lookDirection = mouse_Pos - rb_Player.position;
        lookDirection.y -= Player_Accuary;
        lookDirection.Normalize();

        ProjectileController new_Projectile = Projectile.GetComponent<ProjectileController>();
        new_Projectile.Launch(lookDirection, 7);
    }
}
