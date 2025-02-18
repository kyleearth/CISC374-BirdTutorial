using UnityEngine;

public class PipMoveScript : MonoBehaviour
{   
    public float speed = 5;
    public float destroyX = -45;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //ensure rate   
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
