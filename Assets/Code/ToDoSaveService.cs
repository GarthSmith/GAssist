using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;

public class ToDoSaveService
{
	public void Save(ToDoMemento mementoToSave)
    {
        string savePath = Application.persistentDataPath;
        savePath = Path.Combine(savePath, "todosavedata.json");
        // test
        File.WriteAllText(savePath, "Hello, world!");
        Debug.Log("Combined path: " + savePath);
        // string toSave = mementoToSave.ToJson();
    }
}
