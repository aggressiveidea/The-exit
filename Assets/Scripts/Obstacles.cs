
/*using UnityEngine;

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
        //if (collision.gameObject.CompareTag("Player") && playerMovements != null)
        //{
        //    playerMovements.Die();
      //  }
    //}

    //// Update is called once per frame
   // void Update()
   // {
        
   // }
//}*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacles : MonoBehaviour
{
    PlayerMovements playerMovements;

    // Start is called before the first frame update
    void Start()
    {
        playerMovements = GameObject.FindObjectOfType<PlayerMovements>();
        if (playerMovements == null)
        {
            Debug.LogError("PlayerMovements script not found on any GameObject in the scene.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Player") && playerMovements != null)
        {
            Debug.Log("Player collision detected.");
            playerMovements.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

