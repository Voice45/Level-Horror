using System.Security.Cryptography;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{

    public Transform PlayerCam;
    public bool Invertirtemouse = false;
    //UI
    public GameObject PauseUI; 
    public GameObject EndScrenUI;
    bool GameIsPaused = false;

    //Bewegung
    public float MovementSpeed =10;
    bool isSneak = false;
    public float gravity = -9.81f;
    public float jumpForce = 5f;
    float velocityY;
    static bool DoubleJump = false;
    int JumpsLeft = 1;
    CharacterController controller;
    //Mouse
    public static float RotationSensitivity = 200.0f;
	public float minAngle = -45.0f;
	public float maxAngle = 45.0f;
    float yRotate = 0.0f;
    float xRotate = 0.0f;
    float invert = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PauseUI.SetActive(false);
        EndScrenUI.SetActive(false);
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                UnPause();
            }
            else 
                { 
                    Pause();
                }
        }

        if (Input.GetKey(KeyCode.R))
        {
            Reset();
        }

            sneak();

        //Bewgung mit Gravity
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = PlayerCam.forward * z +PlayerCam.right *x;
        //GetComponent<CharacterController>().Move(movement * MovementSpeed * Time.deltaTime);

        if (controller.isGrounded)
        {
            if (DoubleJump)
            JumpsLeft = 2;
            else
                JumpsLeft = 1;
        }

        if (JumpsLeft > 0)
        {
            if (velocityY <= 0 && !controller.isGrounded)
                velocityY = -2f; 
           
            if (controller.isGrounded && Input.GetButtonDown("Jump"))
            {
                velocityY = jumpForce;
                JumpsLeft -=1;
            }
        }

        void sneak()
        {
            if (isSneak)
                {
                MovementSpeed = 2;
                transform.localScale = new Vector3(1f, .6f, 1f);
                }
            else
                {
                MovementSpeed =10;
                transform.localScale = new Vector3(1f, 1f, 1f);
                }

            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.LeftControl))
                isSneak = true;
            if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.LeftControl))
                isSneak = false;
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
        GameIsPaused = true;
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void UnPause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        GameIsPaused = false;
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Reset()
    {
        SceneManager.LoadScene("Level Horror");
        //EditorSceneManager.OpenScene("Level Horror");
    }
    public void InvertUI()
    {
        if (Invertirtemouse == false)
        Invertirtemouse = true;
        else
            Invertirtemouse = false;
    }

    public void SetSensitivity(float value)
    {
        RotationSensitivity = value;
    }

    public void DoubleJumpUI()
    {
        if (DoubleJump == false)
        DoubleJump = true;
        else
            DoubleJump = false;
    }
}
