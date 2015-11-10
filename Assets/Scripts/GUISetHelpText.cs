using UnityEngine;
using System.Collections;
using System;

public class GUISetHelpText : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<TextMesh>().text = 
            "Move with W,A,S,D"
            + Environment.NewLine
            + Environment.NewLine
            + "Use the left mouse button to shoot"
            + Environment.NewLine
            + "Use the spacebar to jump"
            + Environment.NewLine
            + Environment.NewLine
            + "Destroy all of the targets to win";
    }
}