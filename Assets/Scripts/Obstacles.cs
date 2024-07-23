using UnityEngine;

public class Obstacles : MonoBehaviour
{
    PlayerMovements playerMovements;

    void Start()
    {
        playerMovements = GameObject.FindObjectOfType<PlayerMovements>();
    }

    private void OnCollisionEnter(Collision collision)
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

