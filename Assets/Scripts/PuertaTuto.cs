using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaTuto : MonoBehaviour, ObjetosInteractivosInterface
{
	public void ActivarObjeto()
	{
		//load scene zona dentro
        SceneManager.LoadScene("zonaDentro");
	}

	public Material GetMaterial()
	{
		return null;
	}
}
