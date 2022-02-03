using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballSpawner : MonoBehaviour
{
    public GameObject snowball;
    public Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerExit(Collider other)
    {
        Instantiate(snowball, spawnPos.position, Quaternion.identity);

        Debug.Log("snowball created");
    }
}
