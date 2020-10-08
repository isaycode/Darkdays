using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleload : MonoBehaviour
{
	public GameObject player;

	public void Load()
	{

		player.transform.position=ES3.Load<Vector3>("playerpos","myposition.es3");
		






	}


}


