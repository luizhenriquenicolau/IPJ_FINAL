using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject Collected;
    public int pontuacao;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player") //se o personagem tocar na cenoura
        {

            sr.enabled = false;
            circle.enabled = false;
            Collected.SetActive(true);

            controlador.instance.pontuacaototal+= pontuacao;
            controlador.instance.UpdateScoreText();
            jogador.instance.Speed = 2.9f;
            jogador.instance.JumpForce = 3.9f;

            Destroy(gameObject, 0.5f); //cenoura some
           
            
        }
    }
}
