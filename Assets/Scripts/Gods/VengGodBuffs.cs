﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VengGodBuffs : MonoBehaviour
{
    public GameObject Buff_Prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SendBuff", 10.0f, 30.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SendBuff()
    {
        GameObject Buff = Instantiate(Buff_Prefab, transform.position + new Vector3(0,-10,0), Quaternion.identity);
    }
    
}
