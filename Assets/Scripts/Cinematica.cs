using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematica : MonoBehaviour
{
    //i hve 6 images and i wnato to wait5 seconds, deactiavte the current image and activate the next image
    public GameObject[] images;
    public float waitTime = 5f;
    private int currentImage = 0;
    
    void Start()
    {
        StartCoroutine(ShowImages());
    }

    IEnumerator ShowImages()
    {
        while (currentImage < images.Length)
        {
            images[currentImage].SetActive(true);
            yield return new WaitForSeconds(waitTime);
            images[currentImage].SetActive(false);
            currentImage++;
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");
    }
}
