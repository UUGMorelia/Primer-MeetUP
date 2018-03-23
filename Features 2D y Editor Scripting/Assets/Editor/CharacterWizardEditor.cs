using UnityEditor;
using UnityEngine;

//Aqui no usamos Editor sino ScriptableWizard que contiene funciones especiales para desarrollar herramientas personalizadas en unity
public class CharacterWizardEditor : ScriptableWizard
{
    //Esta variable de tipo Sprite nos permitira almacenar a nuestro Sprite
    public Sprite portraitSprite;
    //Estas variables hacen referencia a las variables de Personaje y nos serviran para mandarles los datos introducidos en la ventana.
    public string nickName = "Default Nick Name";
    public float vida;
    public float mana;
    public float fuerza;
    public float defensa;
    public float speed;
    
    //Aqui añadimos un item nuevo al menu de unity, el nombre de nuestra nuevo menu sera Tools y el sub menu se llamara New Character - Nuevo Personaje
    [MenuItem("Tools/New Character - Nuevo Personaje")]

    //Este metodo nos servira para crear nuestra ventana
    static void CreateWizard()
    {
        //DisplayWizard nos permitira desplegar una ventana  con un titulo,un boton para crear y otro para realizar cualquier accion, esto basado en los elementos del script CharacterWizardEditor
        DisplayWizard<CharacterWizardEditor>("Create Character","New Character", "Update Seleted");
    }
    //Este metodo es creado por Unity y sirve para configurar la opcion de crear en nuestra ventana
    private void OnWizardCreate()
    {
        //Creamos un objeto llamado CharacterGO
        GameObject CharacterGO = new GameObject();

        //le añadimos al CharacterGO un componente para renderear nuestro Sprite al cual le asignamos nuestra varible portraitSprite que recibira el sprite que asignemos en nuestra ventana
        CharacterGO.AddComponent<SpriteRenderer>().sprite = portraitSprite;
        
        //Creamos un objeto llamado componentesPersonaje el cual nos permitira acceder a los elementos del script personaje.
        //En esta seccion tambien añadiremos un componente a CharacterGO, este componente sera el Script Personaje, esto se hace para que lo que modifiquemos del inspector, tambien modifique los datos del script
        Personaje componentesPersonaje = CharacterGO.AddComponent<Personaje>();
        
        //En esta parte accederemos a las propiedades del script personaje y le mandaremos el valor de las variables de este script
        componentesPersonaje.name = nickName;
        componentesPersonaje.pVida = vida;
        componentesPersonaje.pMana = mana;
        componentesPersonaje.pFuerza = fuerza;
        componentesPersonaje.pDefensa = defensa;

        //Aqui creamos una variable para acceder al metodo PlayerMovement al cual tambien le diremos que actualice su informacion en base a lo que modifiquemos en el inspector.
        PlayerMovement playerMovement = CharacterGO.AddComponent<PlayerMovement>();
        //Para asegurarnos de que no existan errores al modificar valores, le asignaremos al playerMovement de personaje el valor del playerMovement de este script
        componentesPersonaje.playerMovement = playerMovement;
        //Finalmente a la variable de velociada en nuestro PlayerMovement le asignamos el valor de la velocidad de este script
        playerMovement.spd = speed;

    }

    //Configuramos con el otro boton 
    private void OnWizardOtherButton()
    {
        //Primero preguntaremos si nuestro objeto seleccionado nos retorna su transform activo, para ver si este objeto esta activo.
        if (Selection.activeTransform != null)
        {
            //De nuevo crearemos una variable componentes de nuestro script personaje, le asiganmos a nuestro Objeto el script personaje.
            Personaje componentesPersonaje = Selection.activeTransform.GetComponent<Personaje>();

            //Vemos si nuestros componentes tienen o no valores.
            if(componentesPersonaje != null)
            {
                //Si tienen valores entonces resetamos nuestros valores a los que tenemos por defecto mas arriba
                componentesPersonaje.name = nickName;
                componentesPersonaje.pVida = vida;
                componentesPersonaje.pMana = mana;
                componentesPersonaje.pFuerza = fuerza;
                componentesPersonaje.pDefensa = defensa;
            }
        }
    }

    //Con este metodo actualizamos los datos
    private void OnWizardUpdate()
    {
        //Mediante esta variable podemos añadir un mensaje que ayude a indicar a nuestro usuario lo que debe hacer.
        //helpstring es parte las funciones de ScriptableWizard por lo que no necesitamos añadir tipo de dato o alguna otra clasificacion.
        helpString = "Introduce los datos de tu personaje";
    }
}
