using System;
using System.IO;
using UnityEngine;

public class DataBase 
{

    private string path = Application.dataPath + "/Saves/";

    public void GuardarData<T>(string guardarNombre, T guardarDatos)
    {
        string jsonToSave = JsonUtility.ToJson(guardarDatos);
        File.WriteAllText(path + guardarNombre + ".json", jsonToSave);

    }

    public void CargarData<T>(string guardarNombre, System.Action<T> callback)
    {
        if(File.Exists(path + guardarNombre + ".json"))
        {
            string loadedJson = File.ReadAllText(path + guardarNombre + ".json");
            callback(JsonUtility.FromJson<T>(loadedJson));
        }
        else
        {
            Debug.Log("El archivo no existe");
        }
    }
}
