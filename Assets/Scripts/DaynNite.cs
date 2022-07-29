using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaynNite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Cada update gira un decimo de grado en el eje X para simular el cambio de dìa y noche
    void Update()
    {
        Vector3 rotationToAdd = new Vector3(0.1f, 0, 0);
        transform.Rotate(rotationToAdd);
    }
}
