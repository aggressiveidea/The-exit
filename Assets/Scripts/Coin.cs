using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Obstacles>() != null)
        {
            Destroy(gameObject);
            return;
        }
        //ida machi l player li colida m3a the coin mysra walou
        if(other.gameObject.name != "Player")
        {
            return;
        }
        GameManager.inst.score++;
        //bach the coin ttdespara 
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
       // Update is called once per frame
    void Update()
    {
        //Time.deltaTime al mouda bin 
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
