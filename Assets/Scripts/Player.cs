using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator animator; // Для корректного использования Анимации
    [SerializeField] private float speed; // Скорость движения влево/вправо
    [SerializeField] private Vector3 direction; // Переменная координат, для движения
    public static Player instance; // Для использования перекменных в других скриптах
    public Rigidbody2D rb; // Публичный RB для игрока
    public SpriteRenderer spriteRenderer; // Спрайт игрока
    public float directionInput; // Заданное направление передвижения

    void Start()
    {
        if (instance == null) // Для корректного использования переменных в других скриптах
        {
            instance = this;                               
        }
    }

    private void Update()
    {
        if (directionInput < 0) // Если игрок движется влево
        {
            spriteRenderer.flipX = true; // Спрайт игрока поворачивается влево
        }

        if (directionInput > 0) // Если игрок движется вправо
        {
            spriteRenderer.flipX = false; // Спрайт игрока поворачивается вправо
        }
        if (rb.velocity.y < 0)
        {
            animator.SetBool("Takeoff", true); // Анимация взлета
        }

        if (rb.velocity.y > 0)
        {
            animator.SetBool("Takeoff", false); // Анимация падения
        }
    }

    void FixedUpdate()
    {
        if (transform.position.x < -3.3) // Если игрок вышел за границы экрана слева
        {
            transform.position = new Vector3(transform.position.x + 6.6f, transform.position.y, transform.position.z); 
            // Перемещается к правой границы экрана
        }
        else if (transform.position.x > 3.3) // Если игрок вышел за границы экрана справа
        {
            transform.position = new Vector3(transform.position.x - 6.6f, transform.position.y, transform.position.z); 
            // Перемещается к левой границы экрана
        }
        
        rb.velocity = new Vector2(speed * directionInput, rb.velocity.y); // Запуск движения 
    }

    public void OnCollisionEnter2D(Collision2D collision) // Столкновение объекта
    {
        if (collision.collider.name == "Endzone") // Если игрок сталкивается с объектом с именем "Endzone"
        {
            SceneManager.LoadScene("MainMenu"); // Выход в меню
            
        }
    }

    public void Move(float InputAxis)
    {
        directionInput = InputAxis; // Перемещение по оси Х 
    }

    public void StopLeftMove() // Плавная остановка движения влево
    {
        direction = Vector2.left;
    }

    public void StopRightMove() // Плавная остановка движения вправо
    {
        direction = Vector2.right;
    }

}
