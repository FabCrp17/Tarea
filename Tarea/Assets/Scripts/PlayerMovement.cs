using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float velocity;
    public Transform spawnPoint;



    void Update()
    {
        float hMove = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(hMove, 0);

        transform.Translate(movement * velocity * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathZone") { transform.position = spawnPoint.position; }
    }
}
