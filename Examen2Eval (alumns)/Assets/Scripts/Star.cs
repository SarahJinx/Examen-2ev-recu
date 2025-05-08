using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)      // Cuando la estrella detecta que mario la ha tocado
    {
        if (GetComponent<MarioScript>())                // Asumiendo la estrella pudiera detectar mario
        {
            Destroy(gameObject);            // La estrella se destruiria
        }
    }
}
