using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Movable
{
    private void Start()
    {
        GameManager.Ingame.Player = this;
    }

    protected override void Update()
    {
        base.Update();
        if (!_isMove)
            GetInput();
    }

    void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
            StartMove(MoveDirection.Up);
        else if (Input.GetKey(KeyCode.S))
            StartMove(MoveDirection.Down);
        else if (Input.GetKey(KeyCode.A))
            StartMove(MoveDirection.Left);
        else if (Input.GetKey(KeyCode.D))
            StartMove(MoveDirection.Right);
    }
}
