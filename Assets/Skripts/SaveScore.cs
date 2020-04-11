using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveScore
{
public static void SaveHigh(PlayerCollision Highscore)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/highscore.score";
        FileStream stream = new FileStream(path, FileMode.Create);

        HScore data2 = new HScore(Highscore);

        formatter.Serialize(stream, data2);
        stream.Close();
    }

    public static HScore LoadHigh()
    {
        string path = Application.persistentDataPath + "/highscore.score";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            HScore data2 = formatter.Deserialize(stream) as HScore;
            stream.Close();

            return data2;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
