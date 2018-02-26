using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ASH_SceneTitle : MonoBehaviour
{
	public void LoadScene()
	{
		SceneManager.LoadScene("scene_game");
	}
}