using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] Rigidbody rbPlayer;
    [SerializeField] float speed;
    private float horizontalAmount;
    private float verticalAmount;

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        horizontalAmount = Input.GetAxis("Horizontal");
        verticalAmount = Input.GetAxis("Vertical");
        Vector3 temp = new Vector3(horizontalAmount, 0, verticalAmount);
        rbPlayer.velocity = temp * speed;
    }

    public float GetHorizontalAmount()
    {
        return horizontalAmount;
    }

    public float GetVerticalAmount()
    {
        return verticalAmount;
    }
}
