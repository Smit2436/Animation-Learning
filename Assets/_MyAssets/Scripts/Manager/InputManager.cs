using UnityEngine;

public class InputManager : MonoBehaviour
{
    [Header("<b>Scriptable")]
    [SerializeField] InputData inputData;

    private void Update() => ReadKeyboardInputs();

    private void ReadKeyboardInputs()
    {
        inputData.xDirection = Input.GetAxisRaw("Horizontal");
        inputData.yDirection = Input.GetAxisRaw("Vertical");
    }
}

