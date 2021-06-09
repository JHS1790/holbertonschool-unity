using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    ///Controller
    private CharacterController controller;
    ///Velocity
    private Vector3 playerVelocity;
    ///<summary>Player Speed</velocity>
    public float playerSpeed = 10.0f;
    ///<summary>Jump Height</velocity>
    public float jumpHeight = 5.0f;
    ///<summary>Gravityt</velocity>
    public float gravity = 5.0f;

    bool jumpLock = false;
    float jumpDecay = 0.0f;

    ///Start
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }
    ///Update
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        if (Input.GetButton("Jump") && controller.isGrounded)
        {
            jumpLock = true;
            jumpDecay = gravity + jumpHeight;
        }
        if (jumpDecay > 0)
            jumpDecay -= 0.5f;
        else
            jumpLock = false;
        move.y = move.y - gravity + jumpDecay;
        if (jumpLock)
            controller.Move(move * Time.deltaTime * (playerSpeed * 2f));
        else
            controller.Move(move * Time.deltaTime * playerSpeed);

        if (gameObject.transform.position.y <= -20)
            gameObject.transform.position = new Vector3(0, 20, 0);
    }

    ///Triggered
    void OnTriggerEnter(Collider other)
    {
        ///wut
    }
}
