using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Shot playershot;
    [SerializeField] float speed;

    PlayerInput player;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
        playershot = GetComponentInChildren<Shot>();

    }

    // Update is called once per frame
    void Update()
    {
        var move = player.actions["Move"].ReadValue<Vector2>();

        rb.linearVelocity = move * speed;

        if (player.actions["Attack"].WasPressedThisFrame())
        {
            playershot.BulletShot();
        }
    }
   
}
