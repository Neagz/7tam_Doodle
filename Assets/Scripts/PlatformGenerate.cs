using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platformPrefab; // Переменная для префаба платформы
    
    void Start()
    {
        Vector3 SpawnerPosition = new Vector3(); // Новый вектор

        for (int i = 0; i < 6; i++) // Генерация 6-и платформ
        {
            SpawnerPosition.x = Random.Range(-1.7F, 1.7F); // Позиция по оси х
            SpawnerPosition.y += Random.Range(1.5F, 3F); // Позиция по оси у 

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity); // Создание префабов и выравнивание по осям
        }
    }
}