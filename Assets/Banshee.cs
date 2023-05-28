using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banshee : Monster
{
    public bool wait=false;
    protected override void Update()
    {
        if(_isMove==true)
        Move();
        else if(wait==false)
        {
            wait=true;
            Invoke("FollowPlayer",0.2f);
        }

    }
    protected override void Move()
    {
        if (Vector3.Distance(transform.position, _desirePos) < 0.01f * _moveSpeed)
        {
            transform.position = _desirePos;
            _isMove = false;
            wait=false;
            _moveVector = Vector2.zero;
        }
        else
            transform.Translate(_moveVector * _moveSpeed * Time.deltaTime);
    }

}
