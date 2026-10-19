using UnityEngine;
// Ejercicio 3
public class NotificadorCubo : MonoBehaviour
{
    public delegate void InteraccionDelegado();
    public static event InteraccionDelegado OnCuboTocaTipo1;
    public static event InteraccionDelegado OnCuboTocaTipo2;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tipo1"))
        {
            OnCuboTocaTipo1();
        }
        else if (other.CompareTag("Tipo2"))
        {
            OnCuboTocaTipo2();
        }
    }
}