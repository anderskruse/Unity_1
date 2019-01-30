using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Respect");
        }

    }
    public void printText()
    {
        Debug.Log("Button 1 Clicked!!!!!!!!");
    }

    public void playSound()
    {
        GetComponent<AudioSource>().Play();
    }

    public void spawnObject()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 1.5f, 0);
        sphere.AddComponent<Rigidbody>();
    }

    public void doNotPress()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(0, 1.5f, 0);
            sphere.AddComponent<Rigidbody>();

        }
        
    }

}
