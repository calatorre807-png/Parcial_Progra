using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;

    void Start() => Destroy(gameObject, 3f);

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    private void OnTriggerEnter(Collider other) { if (other.CompareTag("Meteor")) { Destroy(other.gameObject); Destroy(gameObject); } }
    private void OnTriggerEnter2D(Collider2D other) { if (other.CompareTag("Meteor")) { Destroy(other.gameObject); Destroy(gameObject); } }
}
