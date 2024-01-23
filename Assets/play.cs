using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger vao: " + other.gameObject.tag);

        if (other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Va cham vao: " + other.gameObject.tag);
         if(other.gameObject.tag == "loa")
        {
            
        }
        
    }

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start() => rigidbody2d = GetComponent<Rigidbody2D>();

    int jumpCount = 1;
    float movePrefix = 3;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key was pressed " + jumpCount);
            jumpCount++;

            rigidbody2d.AddForce(Vector2.up * movePrefix, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody2d.AddForce(Vector2.left * movePrefix, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody2d.AddForce(Vector2.right * movePrefix, ForceMode2D.Impulse);
        }
    }
}
