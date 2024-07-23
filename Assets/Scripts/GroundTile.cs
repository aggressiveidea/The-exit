
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
        spawnCpoins();
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.spawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject obstaclePrefab;
    void SpawnObstacle()
    {
        //nplaciw les obstacles randomly 
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //Instantiate is a way to say spawn f unity
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        //spawn the obstacle
    }
    public GameObject coinPrefab;
    void spawnCpoins()
    {
        int coinsTospawn = 10;
        for (int i = 0; i < coinsTospawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPoint(GetComponent<Collider>());
        }
    }
    //hadi la fonction elle retourne un vect3 (3d position)
    //donc entre la borne sup w inf tae l ground we'll be spawning the coins donc at random positions
    Vector3 GetRandomPoint(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if(point != collider.ClosestPoint(point))
        {
            point = GetRandomPoint(collider);
        }
        point.y = 1;
        return point;

    }
}
