﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBattleState : BattleState
{
    public override void Enter()
    {
        base.Enter();
        StartCoroutine(Init());
    }

    IEnumerator Init()
    {
        // Load level data here
        board.Load();
        //Point p = new Point((int)levelData.tiles[0].x, (int)levelData.tiles[0].z);
        //SelectTile(p);
        SpawnTestUnits();
        yield return null;
        owner.ChangeState<SelectUnitState>();

    }

    private void SpawnTestUnits()
    {
        for (int i = 0; i < 3; ++i)
        {
            GameObject instance = Instantiate(owner.heroPrefab) as GameObject;
            Unit unit = instance.GetComponent<Unit>();
            units.Add(unit);
        }
    }
}
