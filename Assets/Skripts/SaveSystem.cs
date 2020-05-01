using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    //stvara file u kojem se spremaju kriptirani podatci
    public static void SaveScore (PlayerCollision pinscore)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/pinscore.score";
        FileStream stream = new FileStream(path, FileMode.Create);

        ScoreData data = new ScoreData(pinscore);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    //na poziv otvara file te omogućuje učitavanje podataka
    public static ScoreData LoadScore()
    {
        string path = Application.persistentDataPath + "/pinscore.score";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ScoreData data = formatter.Deserialize(stream) as ScoreData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }

}
