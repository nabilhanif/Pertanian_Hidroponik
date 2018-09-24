using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	public GameObject namaPlayer;
	public static int kondisi=1;

	public void playButton(){
		SceneManager.LoadScene (1);
	}
	public void creditsButton(){
		SceneManager.LoadScene (2);
	}
	public void settingButton(){
		SceneManager.LoadScene (4);
	}
	public void scoreboardButton(){
		SceneManager.LoadScene (3);
	}
	public void starButton(){
		namaPlayer.SetActive (false);
		kondisi = 0;
	}
}
