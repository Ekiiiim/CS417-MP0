using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchLight : MonoBehaviour
{
    public Light pointLight;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointLight = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += ctx =>
        {
            pointLight.color = new Color(Random.value, Random.value, Random.value);
        };
    }
}
