using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;

    public float moveSpeed = 5f;


    public Rigidbody rb;

    [SerializeField] Vector3 movement;
    private float speed;


    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.z = Input.GetAxisRaw("Vertical");


        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            movement = new Vector3(0, 0, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Danger")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

}
