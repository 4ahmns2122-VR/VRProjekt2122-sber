using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballDestroy : MonoBehaviour
{
    private void Start()
    {
        Invoke("DestroyMe", 5f);
    }

    private void DestroyMe()
    {
        Destroy(gameObject);
    }
    
}
