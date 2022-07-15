using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSave : MonoBehaviour
{
    public Text result; // Текстовое поле результата
    private int s; // Переменная рекорда
    
    private void Update()
    {
        s = PlayerPrefs.GetInt("score"); // Загружаем число из игры в переменную
        if (PlayerPrefs.GetInt("score2") <= s) // Если новое число больше или равно предыдущему
            PlayerPrefs.SetInt("score2", s); // Сохраняем это число и записываем в переменную рекорда

        result.text = PlayerPrefs.GetInt("score2").ToString(); // Выводим результат переводя в нужный тип

    }
}
