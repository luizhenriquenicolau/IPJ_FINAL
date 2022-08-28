using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plafatormamovel : MonoBehaviour
{
    public float tempoparaqueda;

    private TargetJoint2D target;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
          
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")  //se o personagem tocar na plataforma
        {
            Invoke("Queda", tempoparaqueda);

        }

        if (collision.gameObject.tag == "lavas" || collision.gameObject.tag == "colisao2")  //se a plataforma tocar no objeto lavas gamerover
        {
            Destroy(gameObject);

        }
    }

    void Queda()
    {
        target.enabled = false;
    }
}
