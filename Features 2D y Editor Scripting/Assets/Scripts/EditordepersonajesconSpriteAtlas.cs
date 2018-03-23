using UnityEngine;
using UnityEngine.U2D;
//un enum es una funcion para enumerar  elementos, en este caso estos elementos son de tipo Sprite
enum SpriteType { face1, face2, face3, face4}

public class EditordepersonajesconSpriteAtlas : MonoBehaviour {
    //nos permite serializar la variable privada elementoActual de tipo Sprite
    [SerializeField]
    private SpriteType elementoActual;

    private SpriteType ultimoElemento;

    //Esta variable es de tipo Sprite Atlas y nos permite interactuar con un SpriteAtlas
    [SerializeField]
    private SpriteAtlas atlas;

    //Esta variable rend es de tipo SpriteRenderer, SpriteRenderer es el componente por el medio del cual Rendereamos una imagen en la escena
    private SpriteRenderer rend;

	// Use this for initialization
	void Start () {
        //Le asignamos a nuestra variable rend  un componente de tipo Sprite Renderer
        rend = GetComponent<SpriteRenderer>();
        //a la variable ultimoElemento le asignamos el valor face1 de nuestro enum.
        ultimoElemento = SpriteType.face1;
	}
	
	// Update is called once per frame
	void Update () {
        //llamamos a nuestro metodo ChangeSprite
        changeSprite();
	}

    private void changeSprite()
    {
        //con este if evaluamos si el elemento actual es diferente al ultimo elemento asignado.
            if (elementoActual != ultimoElemento)
            {
                //accedemos a la propiedad sprite de nuestra variable rend y le asignamos el sprite del atlas
                //Primero atlas es la variable donde guardamos la informacion de nuestro Sprite Atlas
                //Despues con la propiedad GetSprite obtenemos el nombre de nuestro Sprite para asignarselo a la variable rend
                //elementoActual.ToString es una funcion con la que tomamos el valor de elemento Actual y lo convertimos a String
                //De esta manera decimos que elemento de atlas queremos que nos dibuje en la pantalla
                rend.sprite = atlas.GetSprite(elementoActual.ToString());
            //Finalmente le decimos  al ultimo elemento que sea igual al elemento actual que tenemos ahora
                ultimoElemento = elementoActual;
            }
        
    }
}
