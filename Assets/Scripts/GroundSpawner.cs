using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject[] Ground;
    Vector3 nextSpawnPoint;

    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnGround();
        }
    }

    public void SpawnGround()
    {
        GameObject RandomGameObject = Ground[Random.Range(0, Ground.Length)];
        GameObject temp = Instantiate(RandomGameObject, nextSpawnPoint ,Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }


}
