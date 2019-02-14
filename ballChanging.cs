using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballChanging : MonoBehaviour {

	public GameObject  redBall;
	public GameObject blueBall;
	public GameObject violetBall;
	public GameObject greenBall;
	public GameObject yellowBall;
	public GameObject blackBall;

	public int holder = 0;

	void Start () {
		blueBall.SetActive (false);
		violetBall.SetActive (false);
		greenBall.SetActive (false);
		yellowBall.SetActive (false);
		blackBall.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		//for(holder.GetValue = 0; holder.GetValue > holder.Length; holder.GetValue++){
			
			if(holder == 0){
				redBall.SetActive (true);
				blueBall.SetActive (false);
				violetBall.SetActive (false);
				greenBall.SetActive (false);
				yellowBall.SetActive (false);
				blackBall.SetActive (false);
			}

			if(holder == 1){
				redBall.SetActive (false);
				blueBall.SetActive (true);
				violetBall.SetActive (false);
				greenBall.SetActive (false);
				yellowBall.SetActive (false);
				blackBall.SetActive (false);
			}

			if(holder == 2){
				redBall.SetActive (false);
				blueBall.SetActive (false);
				violetBall.SetActive (true);
				greenBall.SetActive (false);
				yellowBall.SetActive (false);
				blackBall.SetActive (false);
			}

			if(holder == 3){
				redBall.SetActive (false);
				blueBall.SetActive (false);
				violetBall.SetActive (false);
				greenBall.SetActive (true);
				yellowBall.SetActive (false);
				blackBall.SetActive (false);
			}

			if(holder == 4){
				redBall.SetActive (false);
				blueBall.SetActive (false);
				violetBall.SetActive (false);
				greenBall.SetActive (false);
				yellowBall.SetActive (true);
				blackBall.SetActive (false);
			}

			if(holder == 5){
				redBall.SetActive (false);
				blueBall.SetActive (false);
				violetBall.SetActive (false);
				greenBall.SetActive (false);
				yellowBall.SetActive (false);
				blackBall.SetActive (true);
			}
			
		if(holder >= 6){
			holder = 0;
		}
		}


	}
//}
