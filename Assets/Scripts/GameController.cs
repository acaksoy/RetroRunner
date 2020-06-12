using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class GameController : MonoBehaviour
{
    public Camera MainCamera;

    public GameObject player; //Kameradan oyuncu cikinca yok etmek icin
    public GameObject cloud;
    public GameObject tower;
    public GameObject fence;
    
    Vector3 CamPos; //to store and manipulate Camera position. 
    Vector3 cloudPos;
    Vector3 towerPos;
    Vector3 fencePos;

    public float Speed; // Can increase Camera movement Speed.
    private int NewTowerPosX= -640;
    
    void Start()
    {
        Speed = 120.0f;

        CounterSingleton.Tower_Counter = 0;
        CounterSingleton.Width_Tower = 0;

        fencePos.Set(-640.0f, -167.0f, 1);
        Instantiate(fence, fencePos, Quaternion.identity);
        fencePos.Set(MainCamera.transform.position.x + 640.0f, -167.0f, 1);
        Instantiate(fence, fencePos, Quaternion.identity);

        cloudPos.Set(-500,200,10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(-340,241,10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(-270,214,10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(-190,228,10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(100,206,10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(340, 250, 10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(420, 231, 10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(490, 222, 10);
        Instantiate(cloud, cloudPos, Quaternion.identity);
        cloudPos.Set(530, 237, 10);
        Instantiate(cloud, cloudPos, Quaternion.identity);

    }

    void Update()
    {
        CameraMover();   //Moves the Camera to +x.  

        if(CounterSingleton.Tower_Counter < 13)
        {
            TowerCreater();
        }
    }

    void CameraMover() //Moves the Camera to +x.
    {
        CamPos = MainCamera.transform.position;            
        CamPos.x += Speed * Time.deltaTime;     
        MainCamera.transform.position = CamPos;
    }

    void TowerCreater() //Creates tower at random location.
    {
        NewTowerPosX += CounterSingleton.Width_Tower;
        CounterSingleton.Tower_Counter++;
        towerPos.Set(NewTowerPosX, -129, 10);
        Instantiate(tower, towerPos, Quaternion.identity);

    }
}
