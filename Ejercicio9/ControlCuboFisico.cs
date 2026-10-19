using UnityEngine;

// Ejercicio 9
public class ControlCuboFisico : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;
    private Vector3 movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}
