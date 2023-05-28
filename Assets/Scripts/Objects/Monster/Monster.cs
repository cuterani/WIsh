using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Movable
{
    public PlayerController a;
    

    protected override void Update()
    {
        base.Update();
        if (!_isMove)
            FollowPlayer();
    }

    protected void FollowPlayer()
    {
        Vector3 dir =GameManager.Ingame.Player.transform.position - transform.position;

        if(Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
        {
            if (dir.x > 0)
                StartMove(MoveDirection.Right);
            else
                StartMove(MoveDirection.Left);
        }
        else
        {
            if (dir.y > 0)
                StartMove(MoveDirection.Up);
            else
                StartMove(MoveDirection.Down);
        }

    }

    




}
