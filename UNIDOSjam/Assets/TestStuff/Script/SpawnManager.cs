using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject flowerPrefab;
    public float respawnTime;
    private Vector2 screenBounds;
    private float coordX;
    private float coordY;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(FlowerSpawn());
    }

    void Update()
    {
        FlowerSpawn();
    }


    IEnumerator FlowerSpawn()
    {
        while (true)
        {   
            // This limits the spawn places to the area right of entity inside the camera
            coordX = Random.Range(-screenBounds.x + 6, screenBounds.x - 1);
            coordY = Random.Range(-screenBounds.y + 1, screenBounds.y - 1);
            Instantiate(flowerPrefab, new Vector2(coordX, coordY), Quaternion.identity);
            yield return new WaitForSeconds(respawnTime);
        }
    }
}
