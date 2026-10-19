using UnityEngine;
// Ejercicio 2
public class Respuesta : MonoBehaviour
{
    public Notificador notificador;
    public Transform posicionTipo2;
    public Transform posicionCilindro;
    private Rigidbody rb;
    public float velocidad = 5f;
    private bool ocurreEvento = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        notificador.OnCubeCollision += miRespuesta;
    }

    void miRespuesta()
    {
        ocurreEvento = true;
    }

    void FixedUpdate()
    {
        if (ocurreEvento) {
            if (gameObject.CompareTag("Tipo1")) 
            {
                transform.LookAt(posicionTipo2);
            } 
            else if (gameObject.CompareTag("Tipo2"))
            {
                transform.LookAt(posicionCilindro);
            }
            rb.MovePosition(transform.position + transform.forward * velocidad * Time.fixedDeltaTime);
        }
    }

    void OnDestroy()
    {
        notificador.OnCubeCollision -= miRespuesta;
    }
}
