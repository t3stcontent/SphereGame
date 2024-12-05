using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 150f;
    
    private Rigidbody _rb;
    private float h, v;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        
        _rb.AddForce(new Vector3(h, 1, v) * speed * Time.fixedDeltaTime);
        
        //print($"h = {h}\tv = {v}");
    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     if (other.gameObject.tag == "enemy")
    //         Destroy(other.gameObject);
    // }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
            Destroy(other.gameObject);
    }
}
