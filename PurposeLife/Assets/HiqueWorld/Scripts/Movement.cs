using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed ;
    private Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        dir = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
       
    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + dir * Time.deltaTime * speed);
    }
}
