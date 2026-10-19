using UnityEngine;
// Ejercicio 3
public class CambioColorEscudo : MonoBehaviour
{
    public Color colorColision = Color.blue; 

    void OnCollisionEnter(Collision collision)
    {
        // El escudo cambia de color si colisiona con un humanoide del mismo tipo
        if (collision.gameObject.CompareTag("Tipo1") && gameObject.CompareTag("Tipo1") || collision.gameObject.CompareTag("Tipo2") && gameObject.CompareTag("Tipo2"))
        {
            GetComponent<Renderer>().material.color = colorColision;
        }
    }
}