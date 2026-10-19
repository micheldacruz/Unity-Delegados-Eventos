using UnityEngine;
using TMPro;
// Ejercicio 6
public class RecolectorCuboCanvas : MonoBehaviour
{
    private int puntuacion = 0;
    public TextMeshProUGUI textoPuntuacion;

    void Start()
    {
        ActualizarInterfaz(); 
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EscudoTipo1"))
        {
            puntuacion += 5;
            ActualizarInterfaz();
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("EscudoTipo2"))
        {
            puntuacion += 10;
            ActualizarInterfaz();
            Destroy(other.gameObject);
        }
    }

    void ActualizarInterfaz()
    {
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }
}
