using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.gameObject.name);

        if (other.gameObject.GetComponent<Obstacles>() != null)
        {
            Debug.Log("Hit an obstacle, destroying coin.");
            Destroy(gameObject);
            return;
        }

        if (other.gameObject.name != "Player")
        {
            Debug.Log("Not the player, ignoring collision.");
            return;
        }

        if (GameManager.inst == null)
        {
            Debug.LogError("GameManager.inst is null!");
        }
        else
        {
            GameManager.inst.score++;
        }

        Debug.Log("Coin collected by player, destroying coin.");
        Destroy(gameObject);
    }

    void Start()
    {
        // Initialization code if needed
    }

    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
