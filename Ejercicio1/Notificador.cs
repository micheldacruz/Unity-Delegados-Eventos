using UnityEngine;
// Ejercicio 1
public class Notificador : MonoBehaviour
{
    public delegate void CollisionDelegate();
    public event CollisionDelegate OnCubeCollision;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {
            OnCubeCollision();
        }
    }
}
