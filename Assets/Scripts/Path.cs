using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path
{
    private List<GameTile> path;
    private int totalCost;

    public Path()
    {
        path = new List<GameTile>();
    }

    public void AddPoint(GameTile t)
    {
        path.Add(t);
        totalCost += t.GetCost();
    }

    public void RemovePoint(GameTile t)
    {
        path.Remove(t);
    }

    public List<GameTile> GetPath()
    {
        return path;
    }

    public GameTile Get(int i)
    {
        return path[i];
    }

    public GameTile GetLast()
    {
        return path[path.Count - 1];
    }

    public int Count()
    {
        return path.Count;
    }

    public int GetRemainingCost()
    {
        //ignore the first point because that's the starting point
        return totalCost - path[0].GetCost();
    }

    public int GetTotalCost()
    {
        return totalCost;
    }
    
    public void Reset()
    {
        path.Clear();
        path = new List<GameTile>();
    }

    public void reverse()
    {
        path.Reverse();
    }
}
