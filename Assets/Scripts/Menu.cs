using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject playButton; // Кнопка продолжить игру
    public GameObject reloadButton; // Кнопка перезапуска игры
    public GameObject pausedButton; // Кнопка паузы
    public GameObject leftButton; // Кнопка движения влево
    public GameObject rightButton; // Кнопка джвижения враво
    public GameObject backgroundPause; // Затенение фона паузы
    
    private void Start() // При старте игры все кнопки не активны кроме "Паузы" и управления движения
    {
        pausedButton.SetActive(true);
        playButton.SetActive(false);
        reloadButton.SetActive(false);
        leftButton.SetActive(true);
        rightButton.SetActive(true);
        backgroundPause.SetActive(false);
    }

    public void Paused() // При нажатии кнопки "Пауза" активируются остальные кнопки, а сама исчезает
    {
        Score.instance.setStopScore = false; // Счетчик очков в игре отключается
        pausedButton.SetActive(false);
        playButton.SetActive(true);
        reloadButton.SetActive(true);
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        backgroundPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void PausedOff()
    {
        Score.instance.setStopScore = true; // Счетчик очков в игре активируется
        pausedButton.SetActive(true);
        playButton.SetActive(false);
        reloadButton.SetActive(false);
        leftButton.SetActive(true);
        rightButton.SetActive(true);
        backgroundPause.SetActive(false);
        Time.timeScale = 1;
    }

    public void Reloading()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene"); // Перезапуск сцены
    }
}
