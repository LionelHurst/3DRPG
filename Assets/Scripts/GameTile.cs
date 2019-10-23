using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameTile : MonoBehaviour
{
    [SerializeField]
    public int cost;
    public Point pos;

    public int GetCost()
    {
        return cost;
    }
    
    public void Load(Point p)
    {
        pos = p;
        Match();
    }

    void Match()
    {
        transform.localPosition = new Vector3(pos.x, -.5f, pos.y);
        //transform.localScale = new Vector3(1, 0.1f, 1);
    }
}
