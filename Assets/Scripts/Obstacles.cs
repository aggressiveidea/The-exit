using UnityEngine;

public class Obstacles : MonoBehaviour
{
    PlayerMovements playerMovements;

    void Start()
    {
       
        playerMovements = GameObject.FindAnyObjectByType<PlayerMovements>();
    }

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerMovements.Die();
        }
    }

    void Update()
    {

    }
}

