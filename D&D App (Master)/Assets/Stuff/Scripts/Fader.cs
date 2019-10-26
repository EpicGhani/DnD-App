using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour 
{
    public CanvasGroup can;
    IEnumerator Start()
    {
        while (can.alpha < 1)
        {
            can.alpha += Time.deltaTime / 2f;
            yield return null;
        }
        SceneManager.LoadScene("Main");
    }
}
