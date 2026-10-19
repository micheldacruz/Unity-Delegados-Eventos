using UnityEngine;
// Ejercicio 3
public class ObservadorHumanoide : MonoBehaviour
{
    // Asignar en el Inspector el escudo que corresponda a este humanoide
    public Transform escudoObjetivo; 
    public float velocidad = 3f;
    
    private bool moverse = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        NotificadorCubo.OnCuboTocaTipo1 += ReaccionarATipo1;
        NotificadorCubo.OnCuboTocaTipo2 += ReaccionarATipo2;
        // Añadimos la suscripción al cubo físico
        NotificadorCuboFisico.OnCuboTocaTipo1 += ReaccionarATipo1;
        NotificadorCuboFisico.OnCuboTocaTipo2 += ReaccionarATipo2;
    }

    void OnDestroy()
    {
        NotificadorCubo.OnCuboTocaTipo1 -= ReaccionarATipo1;
        NotificadorCubo.OnCuboTocaTipo2 -= ReaccionarATipo2;
        NotificadorCuboFisico.OnCuboTocaTipo1 -= ReaccionarATipo1;
        NotificadorCuboFisico.OnCuboTocaTipo2 -= ReaccionarATipo2;
    }

    // Si el cubo toca un Tipo 1, los Tipo 2 se mueven
    void ReaccionarATipo1()
    {
        if (gameObject.CompareTag("Tipo2")) moverse = true;
    }

    // Si el cubo toca un Tipo 2, los Tipo 1 se mueven
    void ReaccionarATipo2()
    {
        if (gameObject.CompareTag("Tipo1")) moverse = true;
    }

    void FixedUpdate()
    {
        if (moverse)
        {
            // Apuntamos al escudo asegurando que no rote en el eje Y (para que no mire al suelo)
            Vector3 objetivoPlano = new Vector3(escudoObjetivo.position.x, transform.position.y, escudoObjetivo.position.z);
            transform.LookAt(objetivoPlano);
            
            rb.MovePosition(transform.position + transform.forward * velocidad * Time.fixedDeltaTime);
        }
    }
}
