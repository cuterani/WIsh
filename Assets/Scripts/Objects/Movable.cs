using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    public enum MoveDirection
    { 
        Up, Down, Left, Right
    }

    /// <summary> 현재 바라보는 방향 </summary>
    MoveDirection _currDirection = MoveDirection.Down;
    /// <summary> 이동 방향 벡터 </summary>
    Vector2 _moveVector = Vector2.zero;
    /// <summary> 현재 이동 중인 목적지 </summary>
    Vector3 _desirePos;

    /// <summary> 현재 이동 중 여부 </summary>
    protected bool _isMove = false;

    /// <summary> 이동 속도 </summary>
    [SerializeField]
    protected float _moveSpeed = 1f;

    protected virtual void Update()
    {
        if (_isMove)
            Move();
    }

    /// <summary> 해당 방향으로 이동 시작 </summary>
    protected void StartMove(MoveDirection dir)
    {
        _currDirection = dir;
        _isMove = true;

        switch (_currDirection)
        {
            case MoveDirection.Up:
                _moveVector = new Vector2(0, 1);
                break;
            case MoveDirection.Down:
                _moveVector = new Vector2(0, -1);
                break;
            case MoveDirection.Left:
                _moveVector = new Vector2(-1, 0);
                break;
            default:
                _moveVector = new Vector2(1, 0);
                break;
        }

        _desirePos = transform.position + (Vector3)_moveVector;
    }

    /// <summary> 이동 함수 </summary>
    void Move()
    {
        if (Vector3.Distance(transform.position, _desirePos) < 0.01f * _moveSpeed)
        {
            transform.position = _desirePos;
            _isMove = false;
            _moveVector = Vector2.zero;
        }
        else
            transform.Translate(_moveVector * _moveSpeed * Time.deltaTime);
    }
}
