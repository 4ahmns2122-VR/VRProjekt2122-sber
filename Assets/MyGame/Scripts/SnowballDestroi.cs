using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballDestroi : MonoBehaviour
{
    private void Start()
    {
        Invoke("DestroyMe", 2f);
    }

    private void DestroyMe()
    {
        Destroy(gameObject);
    }
    
}
