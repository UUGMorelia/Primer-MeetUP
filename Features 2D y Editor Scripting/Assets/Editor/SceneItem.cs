//Libreria para acceder al editor
using UnityEditor;
//Libreria necesaria para acceder al manejador de escenas del editor
using UnityEditor.SceneManagement;
//Librerias necesarias para interactuar con las escenas mediante el codigo.
using UnityEngine;
using UnityEngine.SceneManagement;

//Creacion de items en el menu
//La palabra clave Editor nos permite comunicar el scripting con el Editor de unity para modificarlo
public class SceneItem : Editor {
    //Accedemos al menu principal del editor  a traves de MenuItem, para crear una nueva seccion, esta seccion es open scene  y Main menu que una sub-seccion dentro de open scene
    [MenuItem("Open Scene/MainMenu")]
    public static void OpenMainMenu()
    {
        //Le mandamos la referencia al metodo OpenScene de la escena a la que queremos acceder
        OpenScene("Introduccion al 2D");
    }

    [MenuItem("Open Scene/9-Slice")]
    public static void OpenLevel1()
    {
        OpenScene("9-Slice");
    }

    [MenuItem("Open Scene/Composite Collider")]
    public static void OpenLevel2()
    {
        OpenScene("Composite Collider");
    }

    [MenuItem("Open Scene/Edit Physics Shape")]
    public static void OpenLevel3()
    {
        OpenScene("Edit Physics Shape");
    }

    [MenuItem("Open Scene/Sorting Layer and Groups")]
    public static void OpenLevel4()
    {
        OpenScene("Sorting Layer and Groups");
    }

    [MenuItem("Open Scene/Sprite Atlas")]
    public static void OpenLevel5()
    {
        OpenScene("Sprite Atlas");
    }

    [MenuItem("Open Scene/Tile Palette")]
    public static void OpenLevel6()
    { 
        OpenScene("Tile Palette");
    }

    [MenuItem("Open Scene/Custom Editor y Escala con Editor")]
    public static void OpenLevel7()
    {
        OpenScene("Custom Editor y Escala con Editor");
    }

    //Este metodo recibe el valor de una variable string que contendra el nombre de la escena a la que queremos acceder
    static void OpenScene(string Scene)
    {
        //Si no se han guardado los cambios preguntamos si quiere guardar los cambios antes de salir de la escena
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            //Buscamos la escena que queremos abrir
            EditorSceneManager.OpenScene("Assets/Scene/" + Scene + ".unity");
        }
    }

}
