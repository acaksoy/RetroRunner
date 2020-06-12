using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Spawns enemys

    public GameObject Enemy_Prefab;
    public GameObject Enemy_Mafia;
    private float Timer = 0.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Spawn_Smombie();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer >= 2.0f)
        {
            Timer = 0;
            Spawn_Smombie();
            Spawn_Mafia();
        }
        Timer += Time.deltaTime;
    }

    void Spawn_Smombie()
    {
        GameObject Smombie = Instantiate(Enemy_Prefab, Camera.main.transform.position + new Vector3(Random.Range(680,720),Random.Range(-175,-350),1) , Quaternion.identity);
        EnemyController SmombieController = Smombie.GetComponent<EnemyController>();
        SmombieController.SetEnemy( 3, 120, "Enemy");
    }
    void Spawn_Mafia()
    {
        GameObject Smombie = Instantiate(Enemy_Mafia, Camera.main.transform.position + new Vector3(Random.Range(680, 720), Random.Range(-165, -330), 1), Quaternion.identity);
        RangeEnemyControl MafiaController = Smombie.GetComponent<RangeEnemyControl>();
        MafiaController.SetEnemy(2, 110, "Enemy");
    }
}
