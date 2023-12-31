using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject CloudPrefab;
    public float spawnRate = 5.0f; // Bulutlarýn spawn hýzý
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }
    }

    void SpawnCloud()
    {
        GameObject newCloud = Instantiate(CloudPrefab, transform.position, Quaternion.identity);
        Destroy(newCloud, 10.0f); // Örneðin, 10 saniye sonra bulutu yok et
    }
}
