using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {

    public int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.GetComponent<PlayerController>() == null)
            return;
        ScoreManeger.AddPoints(pointsToAdd);


            Destroy(gameObject);

    }
}
