using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float forceJump; // Сила прыжка
    public AudioSource audioSource; // Звук соприкосновения с платформой
    
    public void OnCollisionEnter2D(Collision2D collision) // Столкновения
    {
        if (collision.relativeVelocity.y < 0) // Если объект движется вниз
        {
            Player.instance.rb.velocity = Vector2.up * forceJump;  // Добавляем прыжок к переменной
                                                                   // из скрипта "Player"
            audioSource.Play(); // Запуск звука
        }        
    }
    
    public void OnCollisionExit2D(Collision2D collision) // Выход из столкновения
    {
        if (collision.collider.name == "Endzone") // Если платформа встретилась с объектом с именем "Endzone"
        {
            float RandX = Random.Range(-1.7F, 1.7F); // Задаем новую позицию по х
            float RandY = Random.Range(transform.position.y + 15F, transform.position.y + 17F); // И новую позицию по у

            transform.position = new Vector3(RandX, RandY, 0); // Перемещаем объект по заданным координатам
        }
    }
}
