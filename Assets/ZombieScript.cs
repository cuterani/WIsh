using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public Transform target;//플레이어의 Transform 컴포넌트를 저장할 변수
    public float speed = 3f;//좀비의 이동속도
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            //좀비가 플레이어를 향해 이동하도록 코드를 작성
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
