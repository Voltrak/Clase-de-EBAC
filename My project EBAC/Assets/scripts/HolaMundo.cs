using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Se llama antes del primer frame
    void Start()
    {
        print("Algo pasó");

Debug.Log("Algo pasó");
Debug.LogWarning("Algo salió medianamente mal");
Debug.LogError("Algo salió muy mal");
    }

    // Se llama una vez por frame
    void Update()
    {
    }
}