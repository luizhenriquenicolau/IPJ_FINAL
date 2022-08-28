using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{

    public float Speed;
    private Rigidbody2D rig;
    public float JumpForce;

    public bool isJumping;
    public bool pulonoar;

    public GameObject gameOver;

    public static jogador instance;







    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rig = GetComponent<Rigidbody2D>(); //criei a variavel rig que esta sendo associada ao Rigidbody, dessa forma, vou conseguir manipular ela atravez do rigdbody
 
    }

    // Update is called once per frame
    void Update()
    {
        Anda();
      
        Pulo();
    }

    void Anda()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        if (Input.GetAxis("Horizontal") > 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

            if (Input.GetAxis("Horizontal") < 0f)
            {
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
        
      

    }

    void Pulo()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping) //se estou partindo de uma plataforma fixa, tenho direito a 1 pulo
            {
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                pulonoar = false; // nao posso pular no ar depois de ja ter pulado de uma plataforma fixa

            }

            else
            {
                if (pulonoar)
                {
         
                    rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                    pulonoar = false; //caso eu nao tenha pulado de uma plataforma fixa, tenho direito a 1 pulo no ar;
                }
                
            }
        }

    }
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)  //se o personagem tocar em algum objetivo com layer 6, que sao os chaos
        {
            isJumping = false;
            pulonoar = true; //toda vez que eu tocar em um lugar, eu renovo o meu "pulo no ar";

        }

        if (collision.gameObject.tag == "lavas")  //se o personagem tocar em alguma lava
        {
            Destroy(gameObject);
            gameOver.SetActive(true);

        }


    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)  //se o personagem não tocar em algum objetivo com layer 6, que sao os chaos
        {
            isJumping = true;

        }

    }


}
