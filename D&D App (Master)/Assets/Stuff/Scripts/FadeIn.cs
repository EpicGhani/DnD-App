using System.Collections;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public CanvasGroup can;
    IEnumerator Start()
    {
        while (can.alpha >0.05f)
        {
            can.alpha -= Time.deltaTime / 2f;
            yield return null;
        }
        Destroy(gameObject);
    }
}
