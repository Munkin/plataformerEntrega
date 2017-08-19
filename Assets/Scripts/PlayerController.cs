using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vidas myLifes;
    public float speed = 2f;
    public float maxspeed = 5f;
    public bool grounded;
    public float jumPower = 6.5f;
    public ParticleSystem dust;

    private Animator anim;
    private Rigidbody2D rb2d;
    private bool jump;
    private AudioSource audioPlayer;



    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioPlayer = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", grounded);
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            jump = true;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "muerte")
            {
            myLifes.Perdervida(transform);
            }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * speed * h);

        float limitedspeed = Mathf.Clamp(rb2d.velocity.x, -maxspeed, maxspeed);
        rb2d.velocity = new Vector2(limitedspeed, rb2d.velocity.y);

        if (h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
        if (jump)
        {
            rb2d.AddForce(Vector2.up * jumPower, ForceMode2D.Impulse);
            jump = false;
          
        }


    }
    void PolvoPlay()
    {
        dust.Play();
    }
    void PolvoStop()
    {
        dust.Stop();

    }

}
