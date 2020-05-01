using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Save
{
    //stvara file na uređaju u kojem se spremaju kriptirani podatci
    public static void SavePlayer(Shop player)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.select";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data1 = new PlayerData(player);

        formatter.Serialize(stream, data1);
        stream.Close();
    }
     //na poziv otvara file i učitava spremljene podatke
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.select";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data1 = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data1;
        }else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
