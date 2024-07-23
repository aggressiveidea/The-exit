using UnityEngine;

public class Obstacles : MonoBehaviour
{
    PlayerMovements playerMovements;

    void Start()
    {
        
        playerMovements = GameObject.FindAnyObjectByType<PlayerMovements>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerMovements.Die();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovements.Die();
        }
    }

    void Update()
    {
        // Update logic if any
    }
}
