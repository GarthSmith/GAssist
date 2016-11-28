using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ToDoManager : MonoBehaviour
{

    [SerializeField]
    private Text DateText;

    [SerializeField]
    private ToDoListItem ToDoListItem;

    // Use this for initialization
    void Start()
    {
        DateText.text = DateTimeOffset.Now.ToString("ddd, MMM d, yyyy");

        ToDoSaveService saveService = new ToDoSaveService();
        saveService.Save(new ToDoMemento());
    }

    private void OnEnable()
    {
        ToDoListItem.ToDoEdited += HandleToDoEdited;
    }

    private void OnDisable()
    {
        ToDoListItem.ToDoEdited -= HandleToDoEdited;
    }

    void HandleToDoEdited(string newToDoText)
    {
        Memento.DateToDos = new Da
    }

    ToDoMemento Memento;
}
