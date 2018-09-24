using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {

	public GameObject menuPause;
	public GameObject intruksi;
	public GameObject wick;
	public GameObject info1;
	public GameObject info2;
	public GameObject winner;

	public void pauseButton(){
		menuPause.SetActive (true);
	}

	public void resumeButton(){
		menuPause.SetActive (false);
	}

	public void backButton(){
		SceneManager.LoadScene (1);
	}

	public void intruksinya(){
		intruksi.SetActive (false);
		wick.SetActive (true);
		info2.SetActive (true);
	}

	public void info(){
		info1.SetActive (false);
		intruksi.SetActive (true);
	}

	public void win(){
		winner.SetActive (true);
	}

	public void reload(){
		SceneManager.LoadScene (6);
	}
	public void back(){
		SceneManager.LoadScene (1);
	}
	public void next(){
		SceneManager.LoadScene (7);
	}
}
