using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FuncionamientoPistola : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    void Update()
    {
        Shoot();
        Puntaje();
    }
    public void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            var bullet = PoolManager.Instance.GetBullet();
            bullet.transform.position = bulletSpawnPoint.position;
            bullet.transform.rotation = bulletSpawnPoint.rotation;
            bullet.SetActive(true);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }

    void Puntaje() { // función para mostrar el puntaje en pantalla
        // GameObject.FindObjectOfType<UnityEngine.UI.Text>().text = "Puntuación  " + ObjetivosManager.Instance.puntos;
        GameObject.FindWithTag("Score").GetComponent<Text>().text = "Puntuación " + ObjetivosManager.Instance.puntos;
    }
}
