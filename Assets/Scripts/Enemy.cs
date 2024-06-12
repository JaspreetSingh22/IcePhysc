using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
