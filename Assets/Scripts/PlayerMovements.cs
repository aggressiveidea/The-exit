using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovements : MonoBehaviour
{
    bool alive = true;
    public float speed = 5;
    public Rigidbody rb;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    private void FixedUpdate()
    {
        //ida l player khsar we'll stop running the function
        if (!alive) return;
        {
            
        }
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if(transform.position.y < -5)
        {
            Die();
        }
    }
    public static void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
