using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f, range = 8f, fireRate = 0.5f;
    public GameObject bullet;
    public Transform firePoint;
    public AudioClip shootSound;
    private float nextFire;

    void Update()
    {
        float x = transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(x, -range, range), transform.position.y, 0);

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, firePoint.position, Quaternion.identity);
            if (shootSound) AudioSource.PlayClipAtPoint(shootSound, transform.position);
        }
    }

    private void OnTriggerEnter(Collider other) { if (other.CompareTag("Meteor")) Die(); }
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Meteor")) Die(); }
    void Die() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
