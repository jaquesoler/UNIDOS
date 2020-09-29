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

    // This will set the number of times the spawner will spawn flowers, then it will stop.
    public int SpawnRepeater;

    public int FlowersSpawned;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        FlowersSpawned = 0;
        StartCoroutine(FlowerSpawn());
        FlowerSpawn();
   
    }

    IEnumerator FlowerSpawn()
    {
        while (FlowersSpawned <= SpawnRepeater)
        {   
            // This limits the spawn places to the area right of entity inside the camera
            coordX = Random.Range(-screenBounds.x + 15, screenBounds.x - 2);
            coordY = Random.Range(screenBounds.y + 5, screenBounds.y);
            Instantiate(flowerPrefab, new Vector2(coordX, coordY), Quaternion.identity);
            yield return new WaitForSeconds(respawnTime);

            /* FlowersSpawned++ wil increment when its delivered or destroyed. */
        }
    }
}
