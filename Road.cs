using UnityEngine;

public class Road : MonoBehaviour
{
    void Start()
    {
        // Создание куба
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Размер куба
        cube.transform.localScale = new Vector3(20, 1, 20);
        // Позиция куба
        cube.transform.position = Vector3.zero;
    }
}
