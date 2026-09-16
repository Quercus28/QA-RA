using UnityEngine;

/// <summary>
/// Rota el GameObject al que se adjunta este script, usando una velocidad
/// y un eje de rotacion (x, y, z) configurables.
///
/// El eje NO necesita estar normalizado: Unity lo normaliza internamente
/// en Quaternion.AngleAxis. Por ejemplo (0,1,0) rota solo en Y,
/// (1,1,0) rota en diagonal entre X e Y, (0,0,0) no rota nada.
/// </summary>
public class RotarObjeto : MonoBehaviour
{
    [Header("Parametros de rotacion")]
    [Tooltip("Grados por segundo")]
    [SerializeField] private float velocidad = 30f;

    [SerializeField] private float x = 0f;
    [SerializeField] private float y = 1f;
    [SerializeField] private float z = 0f;

    void Update()
    {
        Vector3 eje = new Vector3(x, y, z);

        // Si el eje quedo en (0,0,0) no hay direccion de rotacion valida,
        // evitamos el calculo para no generar una rotacion indefinida.
        if (eje == Vector3.zero)
            return;

        transform.Rotate(eje.normalized * velocidad * Time.deltaTime, Space.Self);
    }

    /// <summary>
    /// Permite cambiar los 4 parametros en tiempo de ejecucion desde otro
    /// script, por ejemplo desde un evento de Vuforia (OnTargetFound) o
    /// desde un controlador de UI.
    /// </summary>
    public void ConfigurarRotacion(float nuevaVelocidad, float nuevoX, float nuevoY, float nuevoZ)
    {
        velocidad = nuevaVelocidad;
        x = nuevoX;
        y = nuevoY;
        z = nuevoZ;
    }
}
