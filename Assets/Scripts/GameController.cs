using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public enum GameState{Idle, Playing};
    public GameState gamestate = GameState.Idle;
    public GameObject uiIdle;
    private AudioSource musicPlayer;

    private void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        

    }


    private void Update()
    {
        if (gamestate==GameState.Idle && (Input.GetKeyDown("up")))
        {
            gamestate = GameState.Playing;
            uiIdle.SetActive(false);
            musicPlayer.Play();
        }
        else if (gamestate == GameState.Playing)
        {

        }
    }
}
