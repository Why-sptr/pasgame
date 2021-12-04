using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Animator anim;

    public Transform playerPutaran;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * move * speed;
        anim.SetFloat("MoveSpeed", Mathf.Abs(move), 0.1f, Time.deltaTime);
        playerPutaran.localEulerAngles = new Vector3(0, move * 90, 0);
    }
}
