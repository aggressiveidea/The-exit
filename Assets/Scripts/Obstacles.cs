
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    PlayerMovements playerMovements;
    // Start is called before the first frame update
    void Start()
    {
       
        playerMovements = GameObject.FindAnyObjectByType<PlayerMovements>();
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerMovements.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
