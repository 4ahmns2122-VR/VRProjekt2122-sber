using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avalanche : MonoBehaviour
{
    public GameObject snowball;
    public GameObject filledHole;
    public GameObject lawine;

    // Start is called before the first frame update
    void Start()
    {
        filledHole.SetActive(false);
        lawine.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        filledHole.SetActive(true);
        lawine.SetActive(true);
    }
}
