using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{

    public Transform PlayerCam;

    public bool Invertirtemouse = false; //Mouse
    //UI
    public GameObject UI; 

    //Bewegung
    public float MovementSpeed =0.1F;
    public float gravity = -9.81f;
    public float jumpForce = 5f;
    float velocityY;
    CharacterController controller;
    //Mouse
    public float RotationSensitivity = 200.0f;
	public float minAngle = -45.0f;
	public float maxAngle = 45.0f;
    float yRotate = 0.0f;
    float xRotate = 0.0f;
    float invert = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.SetActive(false);
        Time.timeScale = 1f;

        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Invertirtemouse)
        {
            invert = -1;
        }
        else
        {
            invert = 1;
        }

        //UI
        if (Input.GetKey(KeyCode.Escape))
            Pause();

        //Bewgung mit Gravity
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = PlayerCam.forward * z +PlayerCam.right *x;
        //GetComponent<CharacterController>().Move(movement * MovementSpeed * Time.deltaTime);

        if (controller.isGrounded)
        {
            if (velocityY <= 0)
                velocityY = -2f; 

           
            if (Input.GetButtonDown("Jump"))
                velocityY = jumpForce;
        }

        
        velocityY += gravity * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;
        move.y = velocityY;

        controller.Move(move * MovementSpeed * Time.deltaTime);

        //Cam Rotation
        yRotate += Input.GetAxis("Mouse X") * RotationSensitivity * Time.deltaTime * invert;
        transform.rotation = Quaternion.Euler(0f, yRotate, 0f);

    
        xRotate -= Input.GetAxis("Mouse Y") * RotationSensitivity * Time.deltaTime * invert;
        xRotate = Mathf.Clamp(xRotate, minAngle, maxAngle);
        PlayerCam.localRotation = Quaternion.Euler(xRotate, 0f, 0f);

    }

    //UI

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        UI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void UnPause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        UI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void InvertUI()
    {
        Invertirtemouse = true;
    }

    public void SetSensitivity(float value)
    {
        RotationSensitivity = value;
    }
}
