using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Classes", menuName = "Stats/PlayerNormal")]
public class PlayerStats : ScriptableObject
{
    new public string name;
    [Header("Stats Start")]
    public float Maxlife;
    public float Maxjump;
    public float Maxspeed;

    [Header("Stats Update")]
    public float life;
    public float jump;
    public float speed;


  

}
