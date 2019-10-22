using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IComparable
{
    public float health;
    public float attack;    
    public float defense;
    public float speed;

    private bool dead = false;

    public int CompareTo(object obj)
    {
        return speed.CompareTo(((Unit)obj).speed);
    }

    public bool IsDead()
    {
        return this.dead;
    }
}
