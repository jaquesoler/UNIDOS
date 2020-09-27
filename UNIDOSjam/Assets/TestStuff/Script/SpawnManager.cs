using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject flowerPrefab;
    public float respawnTime;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(FlowerSpawn());
    }

    void Update() 
    {
        FlowerSpawn();
    }

    private void spawnFlower()
    {
        GameObject a = Instantiate(flowerPrefab);
    }
    IEnumerator FlowerSpawn()
    {
        // Replace after with the winning condition
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnFlower();
        }
    }
}

