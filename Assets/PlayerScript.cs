using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public ZombieScript zombie;//좀비 스크립트를 저장할 변수
    
    // Start is called before the first frame update
    void Start()
    {
        //플레이어의 Transform 컴포넌트를 좀비 스크립트에 전달
        zombie.target = transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
