using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_V2 : MonoBehaviour
{
    void Start()
    {
        //Устанавливает позицию объекта
        Vector3 position = transform.position;
        // Создание куба
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Размер куба
        cube.transform.localScale = new Vector3(20, 1, 20);
        // Копирует позицию объекта для куба
        cube.transform.position = position;
    }
}