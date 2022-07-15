using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text result; // Текстовое поле

    private void Update()
    {
        result.text = PlayerPrefs.GetString("result"); // Выводим результат последней игры
    }
}
