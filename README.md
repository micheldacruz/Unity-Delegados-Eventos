# Unity-Delegados-Eventos

## Ejercicio 1

* **Implementación del Patrón Observador:** Creación e invocación de un evento desacoplado mediante el patrón `delegate` y `event` (`CollisionDelegate` y `OnCubeCollision`).
* **Detección de colisiones físicas:** Integración del evento de física de Unity `OnTriggerEnter` para disparar el evento cuando el cubo interactúa con el cilindro.
* **Ciclo de vida y gestión de memoria:** Limpieza explícita de referencias en `OnDestroy` mediante el operador `-=` para evitar desbordamientos o excepciones por referencias huérfanas en el delegado.

<img width="756" height="356" alt="Ejercicio1 (2)" src="https://github.com/user-attachments/assets/ad13b8a7-e92b-4c99-a237-70ec3e449cc6" />

## Ejercicio 2

* **Importación y configuración de modelos 3D:** Incorporación de assets humanoides externos y resolución de problemas de materiales/shaders según el *Render Pipeline* del proyecto.
* **Transición a físicas en Unity:** Migración del sistema de movimiento basado en `Update` y `Translate` a un sistema físico robusto usando `FixedUpdate` y `Rigidbody.MovePosition`.
* **Orientación espacial automática:** Uso de `transform.LookAt` para encarar dinámicamente a los objetivos asignados antes de aplicar la traslación física.
* **Definición de volúmenes de colisión:** Asignación y ajuste manual de componentes `Capsule Collider` a mallas importadas para interactuar correctamente con el entorno (plano) y la gravedad.

<img width="754" height="356" alt="Ejercicio2 (2)" src="https://github.com/user-attachments/assets/ae4cb988-dc15-4206-aa21-4eec93518c88" />
