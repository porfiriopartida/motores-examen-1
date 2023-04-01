using UnityEngine;
using Random = UnityEngine.Random;

public class RandomCherrySpawner : MonoBehaviour
{
    public Transform CherriesParent;
    public Transform spawnPointsParent; 
    public GameObject CherryPrefab;
    public Float cherriesThreshold;
    private Transform[] spawnPoints;

    private void Start()
    {
        spawnPoints = spawnPointsParent.GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        var activeCherries = CountCherries();
        if (activeCherries < cherriesThreshold.Value)
        {
            SpawnCherry();
        }
    }

    private void SpawnCherry()
    {
        var pos = GetRandomSpawnPosition();
        GameObject.Instantiate(CherryPrefab, pos, Quaternion.identity, CherriesParent);
    }

    private Vector3 GetRandomSpawnPosition()
    {
        var upperIdx = spawnPoints.Length - 1;
        var idx = Random.Range(0, upperIdx);
        return spawnPoints[idx].position;
    }

    private static int CountCherries()
    {
        return GameObject.FindGameObjectsWithTag("Cherry").Length;
    }
}