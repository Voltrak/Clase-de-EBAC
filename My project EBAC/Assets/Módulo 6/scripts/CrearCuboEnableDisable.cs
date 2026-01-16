using UnityEngine;

public class CrearCuboEnableDisable : MonoBehaviour
{
    void OnEnable()
    {
       GameObject.CreatePrimitive(PrimitiveType.Cube);
       GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
       cubo.name = "Cubo_Encendido";
       cubo.transform.position = new Vector3(0, 2, 0); // Arriba
       cubo.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    void OnDisable()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.name = "Cubo_Apagado";
        cubo.transform.position = new Vector3(0, -1, 0); // Abajo
        cubo.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    
}
