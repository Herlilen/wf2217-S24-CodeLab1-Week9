using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    [SerializeField] private Camera _camera;
    public float camSpeed;
    private float xRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * camSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * camSpeed * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.Rotate(Vector3.up * mouseX);
        _camera.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
