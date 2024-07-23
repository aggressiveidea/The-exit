
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    PlayerMovements playerMovements;
    // Start is called before the first frame update
    void Start()
    {
        playerMovements = GameObject.FindObjectOfType<PlayerMovements>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerMovements.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
