using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    public void Update()
    {
        if (player != null)
        {
            transform.position = new Vector3(player.transform.position.x - 1.5f, transform.position.y, transform.position.z);
        }
        
    }
}
