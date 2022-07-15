using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRun : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer; // Спрайт платформы
    public GameObject leftBorder; // Левая граница движения платформы
    public GameObject rightBorder; // Правая граница движения платформы
    public Rigidbody2D rb; // RB платформы
    public bool isRightDirection;
    public float speed; // Скорость движения
    
    private void Update()
    {
        if (transform.position.x > rightBorder.transform.position.x) // Если позиция платформы выходит за границы справа
            isRightDirection = false;
        else if (transform.position.x < leftBorder.transform.position.x) // Или аналогично слева
            isRightDirection = true;
        
        rb.velocity = isRightDirection ? Vector2.right : Vector2.left; // Взависимости от булевой переменной
                                                                       // платформа движется влево, иначе вправо
        rb.velocity *= speed; // Придаем скорости движению
        
        if (rb.velocity.x > 0) // Куда движется игрок - туда и повернут его спрайт
            spriteRenderer.flipX = true;
        if (rb.velocity.x < 0)
            spriteRenderer.flipX = false;
    }
}
