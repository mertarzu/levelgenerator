using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] InputController inputController;

    void Update()
    {
        anim.SetFloat("VelocityX", inputController.GetHorizontalAmount() * 100);
        anim.SetFloat("VelocityZ", inputController.GetVerticalAmount() * 100);
    }
}
