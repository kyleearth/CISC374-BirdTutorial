using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{   
    public LogicScript logic;
    public bool birdIsAlive;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        birdIsAlive = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>().birdIsAlive;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && birdIsAlive == true)
        {
            logic.addScore(1);
            //Debug.Log("Score");
        }
       
    }
}
