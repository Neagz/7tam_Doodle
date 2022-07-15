using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPosition; // Позиция игрока
    void Update()
    {
        if (playerPosition.position.y > transform.position.y) // Если позиция игрока по высоте
                                                              // больше позициии камеры,
                                                              // то позиция камеры по высоте приравнивается к позиции игрока 
        {
            transform.position = new Vector3(transform.position.x, playerPosition.position.y, transform.position.z); 
        }
    }
}
