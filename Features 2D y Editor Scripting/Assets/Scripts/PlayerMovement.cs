using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float spd;

    public void Update()
    {
        //Estos son controles para mover a nuestro personaje
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * spd;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * spd;
        //Esto es para que el personaje se mueva en la escena.
        transform.Translate(x,y,0.0f);
    }
}
