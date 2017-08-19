using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour {

    public int vidas = 3;
    public Text textoVidas;
    public Transform startPosition;

    // Use this for initialization
    void Start() {

        ActualizarMarcadorVidas();

    }

    void ActualizarMarcadorVidas()
    {

        textoVidas.text = "VIDAS:" + vidas;

    }

    public void Perdervida(Transform playerTrans)
    {

        vidas--;
        ActualizarMarcadorVidas();
        CheckLives();
        Reiniciar(playerTrans);

    }

    public void Reiniciar(Transform playerTrans)
    {

        playerTrans.position = startPosition.position;

    }

    public void CheckLives()
    {

        if (vidas <= 0)
        {

            SceneManager.LoadScene(4);

        }
    }

}
