using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargetState : BattleState
{
    public override void Enter()
    {
        base.Enter();
        /*Movement mover = owner.currentUnit.GetComponent<Movement>();
        tiles = mover.GetTilesInRange(board);
        board.SelectTiles(tiles);*/
    }

    protected override void OnMove(object sender, InfoEventArgs<Point> e)
    {
        SelectTile(e.info + pos);
    }

    public override void Exit()
    {
        base.Exit();
        /*board.DeSelectTiles(tiles);
        tiles = null;*/
    }

    protected override void OnFire(object sender, InfoEventArgs<int> e)
    {
        //if (tiles.Contains(owner.currentTile))
            owner.ChangeState<MoveSequenceState>();
    }
}
