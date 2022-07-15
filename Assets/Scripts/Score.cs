using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance; // Для использования перекменных в других скриптах
    public Rigidbody2D rb; // Публичный RB игрока
    public Text numberScore; // Очки игрока
    public bool setStopScore; // Когда счетчик набора очков останавливается
    private float scoreIncrease; // Переменная для увеличения очков
    private int s; // Переменная для перевода из одного типа в другой

    public void Update()
    {
        if (instance == null) // Для корректного использования переменных в других скриптах
        {
            instance = this;                               
        }
        if (setStopScore == true) // Если игра не на паузе
        {
            if (rb.velocity.y > 0) // Если игрок поднимается
                scoreIncrease++; // Ему насчитаваются очки
        }

        s = (int) scoreIncrease; // Перевод из типа float в int
        numberScore.text = scoreIncrease.ToString(); // Выводим количество очков
        PlayerPrefs.SetString("result", numberScore.text); // Сохраняем последний результат
        PlayerPrefs.SetInt("score", s); // Сохраняем значение в int
        
    }
}
