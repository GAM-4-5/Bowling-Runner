using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveKontrola
{
    public static void SaveKont (MainManu broj)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/broj.la";
        FileStream stream = new FileStream(path, FileMode.Create);

        Kontrola data5 = new Kontrola(broj);

        formatter.Serialize(stream, data5);
        stream.Close();
    }

    public static Kontrola LoadKont()
    {
        string path = Application.persistentDataPath + "/broj.la";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Kontrola data5 = formatter.Deserialize(stream) as Kontrola;
            stream.Close();

            return data5;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
