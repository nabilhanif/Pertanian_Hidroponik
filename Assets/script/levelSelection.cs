using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelection : MonoBehaviour {

	public void homeButton(){
		SceneManager.LoadScene (0);
		if (mainMenu.kondisi == 0) {

		}
	}
	public void settingButton(){
		SceneManager.LoadScene (4);
	}
	public void scoreboardButton(){
		SceneManager.LoadScene (3);
	}

	public void lv1(){
		SceneManager.LoadScene (5);
	}
	public void lv2(){
		SceneManager.LoadScene (7);
	}
	public void lv3(){
		SceneManager.LoadScene (8);
	}
	public void lv4(){
		SceneManager.LoadScene (9);
	}
	public void lv5(){
		SceneManager.LoadScene (10);
	}

}
