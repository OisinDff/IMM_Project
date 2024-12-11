using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private bool isOnGround = true;
    private float horizontalInput;
    private float speed = 10.0f;
    private float bounds = 4.50f;
    private float jumpForce = 7.0f;
    public GameObject projectilePrefab;
    public float spawnDistance = 0.1f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //make player jump with space and move left and right 
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keeps player in bounds
        if (transform.position.x < -bounds)
        {
            transform.position = new Vector3(-bounds, transform.position.y, transform.position.z);
        }

        if (transform.position.x > bounds)
        {
            transform.position = new Vector3(bounds, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 spawnOffset = transform.up * spawnDistance;

            Instantiate(projectilePrefab, transform.position + spawnOffset, projectilePrefab.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
