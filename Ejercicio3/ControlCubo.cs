using UnityEngine;
// Ejercicio 3
public class ControlCubo : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * velocidad * Time.deltaTime);
    }
}
