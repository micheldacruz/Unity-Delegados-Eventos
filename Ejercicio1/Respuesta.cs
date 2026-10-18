using UnityEngine;
// Ejercicio 1
public class Respuesta : MonoBehaviour
{
    public Notificador notificador;
    public Transform posicionTipo2;
    public Transform posicionCilindro;
    public float velocidad = 5f;
    private bool ocurreEvento = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notificador.OnCubeCollision += miRespuesta;
    }

    void miRespuesta()
    {
        ocurreEvento = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ocurreEvento) {
            if (gameObject.CompareTag("Tipo1")) 
            {
                transform.Translate((posicionTipo2.position - transform.position).normalized * velocidad * Time.deltaTime, Space.World);
            } else if (gameObject.CompareTag("Tipo2"))
            {
                transform.Translate((posicionCilindro.position - transform.position).normalized * velocidad * Time.deltaTime, Space.World);
            }
        }
    }

    void OnDestroy()
    {
        notificador.OnCubeCollision -= miRespuesta;
    }
}
