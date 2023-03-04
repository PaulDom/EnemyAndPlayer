using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int max_health = 10;
    public AudioSource source;
    public AudioClip damageSound;


    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            print("Количество здоровья" + health);
            source.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);

        }
    }
}
