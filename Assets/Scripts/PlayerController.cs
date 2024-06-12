using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    public Rigidbody rigidbody;
    public float Fspeed = 6f;
    float incTimeInterval = 5f;
    float timePassed;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(8,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        rigidbody.velocity = new Vector3(Fspeed, 0, 0);
        if (Input.GetAxis("Horizontal") != 0)
        {
            this.transform.Translate(0, 0, Input.GetAxis("Horizontal")* Time.deltaTime * speed);
        }
      
        

        if(timePassed > incTimeInterval)
        {
            speedInc();
            timePassed = 0;
        }
    }
    public void speedInc()
    {
        Fspeed += 0.25f;
    }
}
