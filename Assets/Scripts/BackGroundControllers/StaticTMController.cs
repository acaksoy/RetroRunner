using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class StaticTMController : MonoBehaviour
{
    public Tilemap StaticTM;
    public Tile Star;
    public Tile BackGround;
    // Start is called before the first frame update
    void Start()
    {
        int x1 = -640;
        int x2 = 420;
        int y1 = 225;
        int y2 = 345;
        int z = 0;
        StaticTM.SetTile(new Vector3Int(0, 0, 0), BackGround);

        for(int i = 0; i < 20; i++)
        {
            StaticTM.SetTile(new Vector3Int(Random.Range(x1,x2), Random.Range(y1,y2), z), Star);
            x1 += 10;
        }

        /*StaticTM.SetTile(new Vector3Int(-630, 230, 0), Star);
        StaticTM.SetTile(new Vector3Int(-612, 301, 0), Star);
        StaticTM.SetTile(new Vector3Int(-580, 273, 0), Star);
        StaticTM.SetTile(new Vector3Int(255, 312, 0), Star);
        StaticTM.SetTile(new Vector3Int(-459, 200, 0), Star);
        StaticTM.SetTile(new Vector3Int(-400, 340, 0), Star);
        StaticTM.SetTile(new Vector3Int(-342, 255, 0), Star);
        StaticTM.SetTile(new Vector3Int(200, 283, 0), Star);
        StaticTM.SetTile(new Vector3Int(-244, 216, 0), Star);
        StaticTM.SetTile(new Vector3Int(-203, 307, 0), Star);
        StaticTM.SetTile(new Vector3Int(-163, 267, 0), Star);
        StaticTM.SetTile(new Vector3Int(157, 249, 0), Star);
        StaticTM.SetTile(new Vector3Int(-89, 233, 0), Star);
        StaticTM.SetTile(new Vector3Int(19, 333, 0), Star);
        StaticTM.SetTile(new Vector3Int(69, 286, 0), Star);
        StaticTM.SetTile(new Vector3Int(271, 342, 0), Star);
        StaticTM.SetTile(new Vector3Int(321, 245, 0), Star);
        StaticTM.SetTile(new Vector3Int(371, 301, 0), Star);
        StaticTM.SetTile(new Vector3Int(408, 243, 0), Star);*/
    }
}
