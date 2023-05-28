using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BansheeCollider : MonoBehaviour
{
    public float requiredTime = 3f; // 3초
    private float elapsedTime = 0f;
    public bool timecheak = false;
   
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timecheak==true)
            elapsedTime += Time.deltaTime;
        
        if(elapsedTime>=requiredTime)
            Debug.Log("Die");
        
        
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        timecheak=true;
        
        
    
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            timecheak = false;
            elapsedTime = 0f;
        }

    }



}
