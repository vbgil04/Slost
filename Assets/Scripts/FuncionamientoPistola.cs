using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class FuncionamientoPistola : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    private bool slimeFuera = false; //sliem
    private GameObject[] slimes;
    public GameObject balaFuera;
    public GameObject municion;
   
    
    void Start()
    {
        UpdateMunicion();
    }
    void Update()
    {
        Shoot();
        RetornarSlime();
    }
    public void Shoot() {
        if(Input.GetMouseButtonDown(0) && !slimeFuera){
           if(GlobalVariables.cantSlimes>=GlobalVariables.maxSlimes) {
                Debug.Log("No hay slimes en el pool");
                return;
            } else {
                var bullet = PoolManager.Instance.GetBullet();
                bullet.transform.position = bulletSpawnPoint.position;
                bullet.transform.rotation = bulletSpawnPoint.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                UpdateMunicion();
            }
        } 
    }
   
    public void RetornarSlime(){
        if(Input.GetKeyDown(KeyCode.R)){
           slimes = GameObject.FindGameObjectsWithTag("SlimeS");
           if(slimes.Length == 0){
               Debug.Log("No hay slimes en la escena");
               return;
           } else {
                slimes[0].SetActive(false);
                GlobalVariables.cantSlimes--;
                UpdateMunicion();
                Debug.Log("Slime retornado");
           }
        }
    }

    //funcion auxiliar de UI
    private void UpdateMunicion()
    {
        municion.GetComponent<Text>().text = (GlobalVariables.maxSlimes - GlobalVariables.cantSlimes) + " / " + (GlobalVariables.maxSlimes);
    }
}
