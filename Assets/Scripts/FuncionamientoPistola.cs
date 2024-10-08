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

    private GameObject[] slimes;
    void Update()
    {
        Shoot();
        RetornarSlime();
    }
    public void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
           if(GlobalVariables.cantSlimes>=GlobalVariables.maxSlimes){
                Debug.Log("No hay slimes en el pool");
                return;
            } else {
                var bullet = PoolManager.Instance.GetBullet();
                bullet.transform.position = bulletSpawnPoint.position;
                bullet.transform.rotation = bulletSpawnPoint.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            }
        } 
    }
    public void RetornarSlime(){
        if(Input.GetKeyDown(KeyCode.R)){
           slimes = GameObject.FindGameObjectsWithTag("Slime");
           if(slimes.Length == 0){
               Debug.Log("No hay slimes en la escena");
               return;
           } else {
                slimes[0].SetActive(false);
                GlobalVariables.cantSlimes--;
                Debug.Log("Slime retornado");
           }
        }
    }
}
