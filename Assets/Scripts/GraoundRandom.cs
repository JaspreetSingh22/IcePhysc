using UnityEngine;

public class GraoundRandom : MonoBehaviour
{
    GroundSpawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindObjectOfType<GroundSpawner>();
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spawner.SpawnGround();
            Destroy(gameObject, 2);
        }
    }
}
