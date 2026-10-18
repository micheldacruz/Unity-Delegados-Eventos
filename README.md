# Unity-Delegados-Eventos

## Ejercicio 1

* **Implementación del Patrón Observador:** Creación e invocación de un evento desacoplado mediante el patrón `delegate` y `event` (`CollisionDelegate` y `OnCubeCollision`).
* **Detección de colisiones físicas:** Integración del evento de física de Unity `OnTriggerEnter` para disparar el evento cuando el cubo interactúa con el cilindro.
* **Ciclo de vida y gestión de memoria:** Limpieza explícita de referencias en `OnDestroy` mediante el operador `-=` para evitar desbordamientos o excepciones por referencias huérfanas en el delegado.

<img width="756" height="356" alt="Ejercicio1 (2)" src="https://github.com/user-attachments/assets/ad13b8a7-e92b-4c99-a237-70ec3e449cc6" />
