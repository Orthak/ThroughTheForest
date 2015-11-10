using UnityEngine;
using System.Collections;

public class SceneFadeScript : MonoBehaviour
{
    public float timeToFade;

    GameObject[] targets;

    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
        if (targets.Length <= 0)
            StartCoroutine("FadeToRestart");
    }

    IEnumerator FadeToRestart()
    {
        for (float a = 0f; a <= 1f; a += .1f)
        {
            Color changeColor = renderer.material.color;
            changeColor.a = a;
            renderer.material.color = changeColor;
            Debug.Log(renderer.material.color.a.ToString());
            if (a >= 1f)
                break;

            yield return null;
        }

        Application.LoadLevel(0);
    }
}
