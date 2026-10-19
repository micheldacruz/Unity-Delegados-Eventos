using UnityEngine;
using TMPro; 
// Ejercicio 7
public class RecolectorCuboRecompensa : MonoBehaviour
{
    private int puntuacion = 0;
    private int siguienteRecompensa = 100;
    private int recompensasAcumuladas = 0;
    
    public TextMeshProUGUI textoPuntuacion; 
    public TextMeshProUGUI textoRecompensa;

    void Start()
    {
        ActualizarInterfaz(); 
        textoRecompensa.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EscudoTipo1"))
        {
            SumarPuntos(5);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("EscudoTipo2"))
        {
            SumarPuntos(10);
            Destroy(other.gameObject);
        }
    }

    void SumarPuntos(int cantidad)
    {
        puntuacion += cantidad;

        if (puntuacion >= siguienteRecompensa)
        {
            siguienteRecompensa += 100;
            recompensasAcumuladas++;
            MostrarRecompensa();
        }

        ActualizarInterfaz();
    }

    void ActualizarInterfaz()
    {
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }

    void MostrarRecompensa()
    {
        textoRecompensa.text = "¡Recompensa desbloqueada! Total: " + recompensasAcumuladas;
    }
}
