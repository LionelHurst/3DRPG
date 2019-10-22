using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : StateMachine
{
    public Point pos;
    public Board board;
    public GameObject heroPrefab;
    public CameraRig cameraRig;
    public Turn turn = new Turn();
    public List<Unit> units = new List<Unit>();

    void Start()
    {
        ChangeState<InitBattleState>();
    }
}
