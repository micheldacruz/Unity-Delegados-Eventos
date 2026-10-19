using UnityEngine;

public class RecolectorCubo : MonoBehaviour
{
    private int puntuacion = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EscudoTipo1"))
        {
            puntuacion += 5;
            Debug.Log("Escudo Tipo 1 recolectado. Puntuación actual: " + puntuacion);
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("EscudoTipo2"))
        {
            puntuacion += 10;
            Debug.Log("Escudo Tipo 2 recolectado. Puntuación actual: " + puntuacion);
            Destroy(other.gameObject);
        }
    }
}
