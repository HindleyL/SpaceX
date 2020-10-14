using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]float speed=25;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    Vector2 inputMovement;
    bool currentInput = false;
    private bool useOldInputManager;
    //Add a new PlayerControls into the script (the actions we created earlier)

    PlayerControls controls;

    private void Awake()

    {

        //Create a new PlayerControls and assign it

        controls = new PlayerControls();

    }

    public void OnEnable()

    {

        controls.Enable();

    }

    public void OnDisable()

    {

        controls.Disable();

    }

    //This is the “message” receiver mentioned earlier, OnLook is called every time the look button value is changed. Value is the result of what it’s changed for (A Vector2 for look)

    public void OnLook(InputValue value)

    {

        Quaternion deltaRotation =

        Quaternion.Euler(new Vector3(-value.Get<Vector2>().y, 0, value.Get<Vector2>().x) * (Time.deltaTime * 10));

        rb.MoveRotation(rb.rotation * deltaRotation);

        rb.velocity = -transform.up * speed;

    }

    /*private void FixedUpdate()
    {
        Quaternion deltaRotation = 
        Quaternion.Euler(new Vector3(CrossPlatformInputManager.GetAxis("Vertical"), 0, CrossPlatformInputManager.GetAxis("Horizontal"))* Time.deltaTime * 40);

        rb.MoveRotation(rb.rotation * deltaRotation);
        rb.velocity = -transform.up*speed;
    }*/
}
