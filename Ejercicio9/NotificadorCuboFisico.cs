using UnityEngine;

// Ejercicio 9
public class NotificadorCuboFisico : MonoBehaviour
{
    public delegate void InteraccionDelegado();
    public static event InteraccionDelegado OnCuboTocaTipo1;
    public static event InteraccionDelegado OnCuboTocaTipo2;

    // Cambiamos OnTriggerEnter por OnCollisionEnter
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tipo1"))
        {
            OnCuboTocaTipo1();
        }
        else if (collision.gameObject.CompareTag("Tipo2"))
        {
            OnCuboTocaTipo2();
        }
    }
}