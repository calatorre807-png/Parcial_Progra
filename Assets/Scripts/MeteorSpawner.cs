using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float interval = 2f, minX = -8f, maxX = 8f, spawnY = 10f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Instantiate(prefab, new Vector3(Random.Range(minX, maxX), spawnY, 0), Quaternion.identity);
            timer = 0;
        }
    }
}
