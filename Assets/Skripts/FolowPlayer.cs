using UnityEngine;

public class FolowPlayer : MonoBehaviour
{
    public Transform player0;
    public Vector3 offset;


    // Update is called once per frame
    //provjerava di se kugla nalazi te se kamera uvjek nalazi iza nje
    void Update()
    {
        transform.position = player0.position + offset;
    }
}
