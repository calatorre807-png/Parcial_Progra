using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 3f;
    public AudioClip explosionSound;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        if (transform.position.y < -15f) Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) { if (other.CompareTag("Projectile")) Explode(other.gameObject); }
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Projectile")) Explode(other.gameObject); }

    void Explode(GameObject bullet)
    {
        if (explosionSound) AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        GameManager.score++;
        Destroy(bullet);
        Destroy(gameObject);
    }
}
