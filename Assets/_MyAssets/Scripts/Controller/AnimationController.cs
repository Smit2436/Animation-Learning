using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AnimationController : MonoBehaviour
{
    Rigidbody playerRb;

    private void Awake() => playerRb.GetComponent<Rigidbody>();

    private void Update()
    {

    }
}
