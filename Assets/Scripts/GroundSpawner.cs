
using UnityEngine;

public class GroundSpawner : MonoBehaviour
    
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    public void spawnTile()
    {
        //Quaternion.identity so hadi means no rotation 
       GameObject temp =  Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        //m3ntha nextSpawnPoint is the 1st child 
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for(int i =0; i < 15;  i++)
        {
            spawnTile();
        }
    }

    
}
