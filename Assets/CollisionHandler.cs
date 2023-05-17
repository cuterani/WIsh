using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            //플레이어와 좀비 충돌 감지
            Die();
        }
        

    }
    
    private void Die()
    {

        //플레이어가 죽는 동작 구현
        //게임오버 화면 표시, 재시작 등
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
