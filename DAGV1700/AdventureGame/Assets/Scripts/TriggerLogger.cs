using UnityEngine;

public class TriggerLogger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
    }

}
