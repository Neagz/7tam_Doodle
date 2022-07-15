using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformTrap : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision) // Столкновения
    {
        if (collision.relativeVelocity.y < 0) // Если объект движется вниз
        {
            float RandX = Random.Range(-1.7F, 1.7F); // Задаем новую позицию по х
            float RandY = Random.Range(transform.position.y + 20F, transform.position.y + 22F); // И новую позицию по у
            
            transform.position = new Vector3(RandX, RandY, 0); // Перемещаем объект по заданным координатам
        }        
    }
    
    public void OnCollisionExit2D(Collision2D collision) // Выход из столкновения
    {
        if (collision.collider.name == "Endzone") // Если платформа встретилась с объектом с именем "Endzone"
        {
            float RandX = Random.Range(-1.7F, 1.7F); // Задаем новую позицию по х
            float RandY = Random.Range(transform.position.y + 20F, transform.position.y + 22F); // И новую позицию по у

            transform.position = new Vector3(RandX, RandY, 0); // Перемещаем объект по заданным координатам
        }
    }
}
