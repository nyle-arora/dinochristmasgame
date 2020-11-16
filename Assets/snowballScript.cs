using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballScript : MonoBehaviour
{

    public float speed = 6;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // rb.AddForce(Vector2.right * speed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // rb.AddForce(Vector2.right * speed);
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;  
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D c){
        if (c.gameObject.tag.Equals("dino")){
            scoreScript.scoreValue += 1;
            Destroy(gameObject);
        }
    }
}