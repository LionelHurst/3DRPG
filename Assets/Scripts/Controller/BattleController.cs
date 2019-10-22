using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : StateMachine
{
    public Point pos;
    public Board board;

    void Start()
    {
        ChangeState<InitBattleState>();
    }
}
