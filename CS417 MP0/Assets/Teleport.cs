using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    public Vector3 teleportLocation = new Vector3(20, 20, 40);
    public Vector3 teleportRotation = new Vector3(0, 225, 0);
    public Vector3 originalLocation = new Vector3(0, 0, 0);

    private bool teleported = false;
    
    void Start()
    {
        action.action.Enable();
        action.action.performed += ctx =>
        {
            transform.position = teleported ? originalLocation : teleportLocation;
            if (!teleported)
            {
                transform.rotation = Quaternion.Euler(teleportRotation);
            }
            teleported = !teleported;
        };
    }
}
