using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum SelectionType
{
    None,
    Play,
    Exit,
    Help,
    Menu
}

public class GUISelectionText : MonoBehaviour
{
    public SelectionType actionType;
    public Color startColor;
    public Color onHover;
    public List<string> newTextList;
    public float forwardPosition;
    public bool changeText;

    TextMesh thisTextMesh;
    Vector3 forwardVector;
    Vector3 originalVector;
    string currentText;

    #region Unity Methods
    void Start()
    {
        thisTextMesh = this.gameObject.GetComponent<TextMesh>();

        // Store the new position in a vector, so we can apply it to the object.
        forwardVector = new Vector3(transform.position.x,
                                    transform.position.y,
                                    transform.position.z - forwardPosition);

        // Store the old position, so that we can revert back when we need to.
        originalVector = new Vector3(transform.position.x,
                                     transform.position.y,
                                     transform.position.z);

        currentText = thisTextMesh.text;
    }

    void OnMouseOver()
    {
        ChangeText("Enter");
        transform.position = forwardVector;
        thisTextMesh.color = onHover;
    }

    void OnMouseExit()
    {
        ChangeText("Exit");
        transform.position = originalVector;
        thisTextMesh.color = startColor;
    }

    void OnMouseDown()
    {
        switch (actionType)
        {
            case SelectionType.Play:
                Application.LoadLevel("MainScene");
                break;
            case SelectionType.Exit:
                Application.Quit();
                break;
            case SelectionType.Help:
                ShowHideHelp();
                break;
            case SelectionType.Menu:
                Application.LoadLevel("MainMenuScene");
                break;
            case SelectionType.None:
                break;
        }
    }
    #endregion

    void ChangeText(string source)
    {
        int rand = Random.Range(0, newTextList.Count);

        if (changeText && source == "Enter")
        {
            if (thisTextMesh.text == currentText)
                thisTextMesh.text = newTextList[rand];
        }
        else if(changeText && source == "Exit")
        {
            thisTextMesh.text = currentText;
        }
    }

    void ShowHideHelp()
    {
        var textMesh = GameObject.Find("HelpText").GetComponent<TextMesh>();
        if(textMesh != null)
            gameObject.SetActive(!gameObject.activeSelf);
    }
}