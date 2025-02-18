using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 12f;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //gameObject.name = "Bob";
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        if (transform.position.y < -18 || transform.position.y > 18)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

private void OnCollisionEnter2D(Collision2D collision)
{   
    //logic.gameOver();
    //Debug.Log("Collision detected with: " + collision.gameObject.name);
    //Debug.Log("Game Over 2");
    logic.gameOver();
    //Debug.Log("Game Over 3");
    birdIsAlive = false;
}


}
