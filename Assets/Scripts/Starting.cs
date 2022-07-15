using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starting : MonoBehaviour
{
    public void StartLevel() // Запуск сцены игры
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ResultLevel() // Запуск сцены с рекордом игры
    {
        SceneManager.LoadScene("ResultScene");
    }

    public void LevelMenu() // Запуск начального экрана игры
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReloadScore()
    {
        PlayerPrefs.DeleteAll(); // Удаляет рекорд
    }

    public void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("result"); // При выходе из игры удаляет последнее значение очков
    }
}
