using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class controlador : MonoBehaviour
{

    public int pontuacaototal;
    public Text scoreText;

    

    public static controlador instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    


   public void UpdateScoreText()
    {

        scoreText.text = pontuacaototal.ToString();
    }

    public void menuInicial()
    {
        SceneManager.LoadScene("nivel_1"); //reinicia a fase 1
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reinicia a fase atual
    }



}

