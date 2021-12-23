using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FackelScript : MonoBehaviour
{
    //von David D. und Simon E.
    public GameObject meltableWall;
    private bool isMoving = false;
    public float speed;

    private void Update()
    {
        if (isMoving)
        {
            Vector3 position = gameObject.transform.position;
            position.y -= Time.deltaTime * speed;
            gameObject.transform.position = position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fackel"))
        {
            isMoving = true;
            Destroy(meltableWall, 3f);
        }
    }
}
