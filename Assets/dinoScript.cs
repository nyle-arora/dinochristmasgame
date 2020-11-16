using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoScript : MonoBehaviour
{

	public float speed = 2;
    public AudioClip a;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D c){
        if (c.gameObject.GetComponent<snowballScript>()){
            AudioSource.PlayClipAtPoint(a, GetComponent<Transform>().position);
            //GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
        if (c.gameObject.tag.Equals("tree")){
            winLoseScript.lost = true;
        }
    }
}
