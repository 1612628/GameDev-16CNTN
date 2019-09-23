using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaperManWalking : MonoBehaviour
{
    public float maxSpeed = 10;
    public float speed = 50f;
    public float jumpPower = 150f;
    
    public bool grounded;

    private Rigidbody2D rg2d;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rg2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetButtonDown("Jump") && grounded)
        {
            rg2d.AddForce(Vector2.up * jumpPower);
        }


        transform.localScale = new Vector3(-0.2f, 0.2f, 1);

        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }



    }

    private void FixedUpdate()
    {


        float h = Input.GetAxis("Horizontal");
        rg2d.AddForce((Vector2.right * speed) * h);

        if (rg2d.velocity.x > maxSpeed)
        {
            rg2d.velocity = new Vector2(maxSpeed, rg2d.velocity.y);
        }

        if (rg2d.velocity.x < -maxSpeed)
        {
            rg2d.velocity = new Vector2(-maxSpeed, rg2d.velocity.y);
        }



    }

}
