using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    //����� ������������
    public string sceneload;
    //������, ���������� �� ������������ �����
    public AudioSource audioSource;
    //�������� ����, ���������� ���� �����
    public AudioClip damageSound;


    //�����, ���������� �������� ������
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            print("�������� ������: " + health);
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            SceneManager.LoadScene(sceneload);
        }
    }
}

