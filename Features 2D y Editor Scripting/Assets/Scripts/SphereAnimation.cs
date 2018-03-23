using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAnimation : MonoBehaviour {
    //variable para dar un tamaño base al objeto
    public float baseSize = 1f;
	
	// Update is called once per frame
	void Update () {
        //esta variable nos servira para el escalado del objeto.
        //Esta variable recibira la informacion de baseSize y le agregan el valor obtenido de la funcion Math.Sin
        //Mathf contiene una serie de funciones matematicas, Sin nos devuelve el Seno del objeto, Time nos sirve para obtener la informacion del tiempo de nuestra interfaz, time obtiene la informacion en segundos desde que empieza el juego
        float animation = baseSize + Mathf.Sin(Time.time * 8f) * baseSize / 7f;
        ///transform localscale es para interactuar con el componente transform y su elemento scale
        //Vector3 es por que  el elemeno scale es un vertor con 3 dimensiones, one es por que dira 1,1,1 a nuestro vector lo multiplicamos porl el parametro que nos retorne animation.
        transform.localScale = Vector3.one * animation;
	}
}
