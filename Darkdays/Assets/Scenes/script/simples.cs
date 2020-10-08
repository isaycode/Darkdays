using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class simples : MonoBehaviour
{
    // Start is called before the first frame update
 public GameObject player;


 public void Save()
 {

	ES3.Save("playerpos",player.transform.position,"myposition.es3");
	ES3.Save(SceneManager.GetActiveScene().name,"myposition","Scenes");
	

 }

}
