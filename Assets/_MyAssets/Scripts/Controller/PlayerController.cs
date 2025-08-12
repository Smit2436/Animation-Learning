using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("<b>Components")]
    [SerializeField] private Rigidbody player;

    [Header ("<b>Scriptable")]
    [SerializeField] private InputData inputData;
    [SerializeField] private PlayerData playerData;

    Vector3 velocityVector = Vector3.zero;

    private void Awake() => player = GetComponent<Rigidbody>();

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        velocityVector = transform.forward * inputData.yDirection + transform.right * inputData.xDirection;
        player.linearVelocity = velocityVector.normalized * playerData.playerSpeed;
    }
}
