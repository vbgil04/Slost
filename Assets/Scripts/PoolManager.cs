using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance;
    public GameObject balasPrefab;
    public GameObject slimePrefab;
    private int BulletPoolSize = 20;
    private int SlimePoolSize = GlobalVariables.maxSlimes;
      public List<GameObject> bulletPool; // pool de balas
      public List<GameObject> slimePool; 

      void Awake() {
        if (Instance == null) { 
            Instance = this;
        } else {
            Destroy(gameObject);
            return;
        } 
        bulletPool = CreatePool(balasPrefab, BulletPoolSize); // creo los pools
        slimePool = CreatePool(slimePrefab, SlimePoolSize);
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
    public GameObject GetSlime(){
        foreach (GameObject obj in slimePool) {
            if (!obj.activeInHierarchy) {
                return obj;
            }
        }
        return null;
    }

}
