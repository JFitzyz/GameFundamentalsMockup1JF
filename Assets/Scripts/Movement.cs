using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    InputAction moveAction;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        
        transform.Translate(new Vector3((float)(moveValue.x * 0.1), moveValue.y, 0));
    }
}