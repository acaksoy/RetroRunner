using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSingleton : MonoBehaviour
{
    private static int  tower_counter; //Global variable for number of cloud, tower & fence in scene
    private static int width_tower;
    public static int Tower_Counter
    {
        get
        {
            return tower_counter;
        }
        set
        {
            tower_counter = value;
        }
    }
    public static int Width_Tower
    {
        get
        {
            return width_tower;
        }
        set
        {
            width_tower = value;
        }
    }
}
