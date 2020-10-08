using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuload : MonoBehaviour
{
    
	public string leveltoload;


	public void Load()
	{

		transform.position=ES3.Load<Vector3>("playerpos","myposition.es3");
		leveltoload=ES3.Load<string>("scenes","savedscene.es3");
		SceneManager.LoadScene(leveltoload);


	}

}
