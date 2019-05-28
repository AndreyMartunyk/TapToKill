using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public bool isSpawning = true;
    public Vector2 spawnArea = new Vector2(2f, 3.5f);
    public float spawnSpeed = 2f;

    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        if (prefabs == null || prefabs.Length == 0)
        {
            Debug.LogWarning("No prefabs was add to spawner!!!");
            return;
        }

        StartCoroutine(SpawnCor());


    }

    IEnumerator SpawnCor()
    {
        while (isSpawning)
        {
            Spawn(prefabs[Random.Range(0,prefabs.Length)]);
            yield return new WaitForSeconds(Time.deltaTime / spawnSpeed);

        }


    }

    private void Spawn(GameObject obj)
    {
        Instantiate(obj, GetRandomPos(), Quaternion.identity);
    }

    private Vector2 GetRandomPos()
    {
        return new Vector2(Random.Range(-spawnArea.x, spawnArea.x), Random.Range(-spawnArea.y, spawnArea.y));
    }


}
