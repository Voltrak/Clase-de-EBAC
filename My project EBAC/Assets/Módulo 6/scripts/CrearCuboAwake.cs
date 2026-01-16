using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{
    void Awake()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.name = "Cubo_Awake";
        cubo.transform.position = new Vector3(-2, 1, 0); 
        
        cubo.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
