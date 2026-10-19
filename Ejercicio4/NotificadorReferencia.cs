using UnityEngine;
// Ejercicio 4
public class NotificadorReferencia : MonoBehaviour
{
    public delegate void InteraccionDelegado();
    public static event InteraccionDelegado OnCuboProximo;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {
            OnCuboProximo();
        }
    }
}
