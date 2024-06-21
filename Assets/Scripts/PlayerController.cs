using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10;
    private Vector2 moveInput;

    private Animator animator;
    private Rigidbody _rigidbody;

    private bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);

            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);

            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, -135, 0);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);

            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, -45, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking", true);

            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 135, 0);
        }

        if (Input.GetKey(KeyCode.W) &&  Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.Space) && isOnGround)
        {
            animator.SetBool("isJumping", true);

            _rigidbody.AddForce(Vector3.up * 1500, ForceMode.Impulse); 
            isOnGround = false;
        }

        if (Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == false && Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
        {
            animator.SetBool("isWalking", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ground"))
            return;

        isOnGround = true;
        animator.SetBool("isJumping", false);
    }

    private void FixedUpdate()
    {

    }
}
