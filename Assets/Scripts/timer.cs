using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{

    public Text timeLevel_txt;
    private float timeLevel;
    public static bool stopTime;
    // Start is called before the first frame update
    void Start()
    {
        stopTime = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTime == false) //se ainda não declarei o stopTime como false, ou seja, se ainda não morri ou reiniciei a fase
        {
            timeLevel = timeLevel + Time.deltaTime; //somo o tempo percorrido na fase à variavel timeLevel
            timeLevel_txt.text = timeLevel.ToString("0");

        }

        if (timeLevel >= 50.0f) //se já se passou mais de 50 segundos e ainda não conclui a fase ou morri
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reinicia a fase
            timer.stopTime = true; // declara stopTime como true, para reiniciar o cronometro
        }
        
    }
}
