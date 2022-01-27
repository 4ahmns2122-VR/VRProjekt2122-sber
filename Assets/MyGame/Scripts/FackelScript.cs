using UnityEngine;

public class FackelScript : MonoBehaviour
{
    //von David D. und Simon E.
    public GameObject meltableWall;
    private bool isMoving = false;
    public float speed;
    AudioSource meltSFX;

    private void Start()
    {
        meltSFX = gameObject.GetComponent<AudioSource>();
        meltSFX.enabled = false;
    }
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
            meltSFX.enabled = true;
        }
    }
}
