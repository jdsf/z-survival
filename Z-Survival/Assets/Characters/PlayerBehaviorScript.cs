using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerBehaviorScript : MonoBehaviour {
    // Variable to contain move direction in X axis
    float dirX;

    // Variable for move speed 
    public float moveSpeed = 8f;

    // Rigidbody2D reference
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get dirX when button is pressed
        dirX = CrossPlatformInputManager.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // Pass velocity to Rigidbody2D
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }
}

