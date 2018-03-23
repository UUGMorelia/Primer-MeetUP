using UnityEngine;
using System.Collections;

public  class Personaje : MonoBehaviour {
   //Esta linea oculta elementos publicos que no queramos que se muestren en el inspector
    [HideInInspector]
    public string nickName;
    //Serie de variables tipo float para los atributos del personaje
    public float pVida;
    public float pMana;
    public float pFuerza;
    public float pDefensa;
    //Esta es un variable de tipo PlayerMovement que nos sirve para acceder las propiedades del script PlayerMovement
    public PlayerMovement playerMovement;
    
}
