using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;
    private bool Face = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * 8000);

        if (moveX > 0 && !Face)
            flip();
        else if (moveX < 0 && Face)
            flip();

      }
    void flip ()
    {
        Face = !Face;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
       
    }

}

