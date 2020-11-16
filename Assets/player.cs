using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 2f;

    public GameObject snowball;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Vertical");

        // Set Velocity (movement direction * speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.up * h * speed;

    }

    void Update(){
        if (winLoseScript.lost)
            Time.timeScale = 0;
        if (Input.GetKeyDown(KeyCode.Space)){
            Vector3 posn = transform.position;
            posn.x += 0.5f;
            Instantiate(snowball, posn, Quaternion.identity);
        }
        if (winLoseScript.lost || scoreScript.scoreValue >= 3){
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D c){
        if (c.gameObject.tag.Equals("fire") || c.gameObject.tag.Equals("dino")){
            winLoseScript.lost = true;
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
