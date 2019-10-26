using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour 
{
	public CanvasGroup can;
	IEnumerator Start() 
	{
		while(can.alpha < 1)
		{
			can.alpha += Time.deltaTime / 2f;
			yield return null;
		}
		yield return new WaitForSeconds(1.5f);
		while(can.alpha > 0)
		{
			can.alpha -= Time.deltaTime / 2f;
			yield return null;
		}
        if (PlayerPrefs.GetInt("FirstSetup") == 0)
            SceneManager.LoadScene("Setup");
        else
            SceneManager.LoadScene("Main");
	}
	
}
