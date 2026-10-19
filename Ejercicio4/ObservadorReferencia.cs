using UnityEngine;
// Ejercicio 4
public class ObservadorReferencia : MonoBehaviour
{
    public Transform objetoObjetivo;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        NotificadorReferencia.OnCuboProximo += miRespuesta;
    }

    void OnDestroy()
    {
        NotificadorReferencia.OnCuboProximo -= miRespuesta;
    }

    void miRespuesta()
    {
        if (gameObject.CompareTag("Tipo1"))
        {
            transform.position = objetoObjetivo.position;
        }
        else if (gameObject.CompareTag("Tipo2"))
        {
            transform.LookAt(new Vector3(objetoObjetivo.position.x, transform.position.y, objetoObjetivo.position.z));
        }
    }
}
