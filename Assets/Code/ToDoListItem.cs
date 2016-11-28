using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This controls one ToDo item in the day's list in the ui.
/// </summary>
public class ToDoListItem : MonoBehaviour
{
    public event Action<string> ToDoEdited;

    [SerializeField]
    private InputField ToDoInputField;

    public string Text
    {
        get { return ToDoInputField.text; }
        set { ToDoInputField.text = value; }
    }

    private void OnEnable()
    {
        ToDoInputField.onEndEdit.AddListener(HandleOnEndEdit);
    }

    private void OnDisable()
    {
        ToDoInputField.onEndEdit.RemoveListener(HandleOnEndEdit);
    }

    private void HandleOnEndEdit(string toDoText)
    {
        Debug.Log(toDoText);
        if (ToDoEdited != null)
            ToDoEdited(toDoText);
    }
}
