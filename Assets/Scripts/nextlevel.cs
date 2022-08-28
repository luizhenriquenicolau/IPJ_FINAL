using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextlevel : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D collision)
    {
     
        if (controlador.instance.pontuacaototal >= 1 && collision.gameObject.tag == "Player") //se o player ja capturou uma cenoura e tocou na casinha
            {

           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //proxima fase
            timer.stopTime = true; //stoptime = true para reiniciar o cronometro

            }
     
    
    }
}
