using UnityEditor;
using UnityEngine;
//Indica a la clase del Editor qué tipo de ejecución realizara sobre el Editor  
[CustomEditor(typeof(SphereAnimation))]
public class SphereEditor : Editor {
    //Variables para marcar el limite del tamaño de nuestro objeto
    private float min = 0.1f;
    private float max = 2f;
    

    public override void OnInspectorGUI()
    {
        //creamos una variable de tipo SphereAnimation para acceder a sus propiedades (este es el script con el que nos comunicamos en el inspector)
        SphereAnimation sphere = (SphereAnimation) target;

        //Guilayout es para interactuar con el inspector, label nos creara un label en el inspector el resto es el mensaje que enviamos a nuestro inspector
        GUILayout.Label("Advertencia: El tamaño de la esfera no puede ser mayor a:" + max);
       
        //La variable que sphere hace referencia a las propiedades del objeto que tiene el script SphereAnimation
        //baseSize es una variable del script SphereAnimation que nos permitira interactuar con el tamaño del objeto
        //EditorGuilayout servira para interactuar en tiempo real con los elementos que se pintan en el inspector, Slider es para dibujar un slide en el inspector lo datos dentro de esta funcion serviran para configurar su comportamiento en el inspector
        sphere.baseSize = EditorGUILayout.Slider("Size", sphere.baseSize, min, max);
       
        //Sphere transform localscale es para interactuar con el componente transform y su elemento scale
        //Vector3 es por que  el elemeno scale es un vertor con 3 dimensiones, one es por que dira 1,1,1 a nuestro vector lo multiplicamos porl el parametro que nos retorne Sphere.baseSize.
        sphere.transform.localScale = Vector3.one * sphere.baseSize;
        
    }

}
