using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 Direction { get; private set; }
    public bool IsAiming { get; private set; }
    public bool IsShooting { get; private set; }

    private void Update()
    {
        Direction = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
        );

        if (Input.GetButtonDown("Interact"))
        {
            SendMessage("OnInteractPressed", SendMessageOptions.DontRequireReceiver);
        }

        IsAiming = Input.GetButton("Aim");
        IsShooting = Input.GetButton("Shoot");
    }
}
