using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance;
    public GameObject balasPrefab;
    public GameObject slimePrefabSuelo;
    public GameObject slimePrefabTecho;
    public GameObject slimePrefabPared;
    private int BulletPoolSize = 20;
    private int SlimePoolSize = GlobalVariables.maxSlimes;
      public List<GameObject> bulletPool; // pool de balas
      public List<GameObject> slimePoolSuelo; 
      public List<GameObject> slimePoolTecho; 
      public List<GameObject> slimePoolPared;
      void Awake() {
        if (Instance == null) { 
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
            return;
        } 
        bulletPool = CreatePool(balasPrefab, BulletPoolSize); // creo los pools
        slimePoolSuelo = CreatePool(slimePrefabSuelo, SlimePoolSize);
        slimePoolTecho = CreatePool(slimePrefabTecho, SlimePoolSize);
        slimePoolPared = CreatePool(slimePrefabPared, SlimePoolSize);
    }
    List<GameObject> CreatePool(GameObject prefab, int size){ 
        var lista = new List<GameObject>(); 
        for (int i = 0; i < size; i++) { 
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            lista.Add(obj);
        }
        return lista; 
    }
    public GameObject GetBullet(){
        foreach (GameObject obj in bulletPool) {
            if (!obj.activeInHierarchy) {
                return obj;
            }
        }
        return null;
    }
    public GameObject GetSlimeSuelo(){
        foreach (GameObject obj in slimePoolSuelo) {
            if (!obj.activeInHierarchy) {
                return obj;
            }
        }
        return null;
    }
    public GameObject GetSlimeTecho(){
        foreach (GameObject obj in slimePoolTecho) {
            if (!obj.activeInHierarchy) {
                return obj;
            }
        }
        return null;
    }
    public GameObject GetSlimePared(){
        foreach (GameObject obj in slimePoolPared) {
            if (!obj.activeInHierarchy) {
                return obj;
            }
        }
        return null;
    }
}
