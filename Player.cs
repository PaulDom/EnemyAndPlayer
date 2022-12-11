using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    //сцена перезагрузки
    public string sceneload;
    //Объект, отвечающий за проигрывание звука
    public AudioSource audioSource;
    //Звуковой файл, содержащий звук урона
    public AudioClip damageSound;


    //Метод, понижающий здоровье игрока
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            print("Здоровье игрока: " + health);
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            SceneManager.LoadScene(sceneload);
        }
    }
}

