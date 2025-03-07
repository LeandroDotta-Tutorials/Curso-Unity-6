using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Animator healthItem1;
    public Animator healthItem2;
    public Animator healthItem3;

    public void SetHealth(int health)
    {
        healthItem1.SetBool("active", health >= 3);
        healthItem2.SetBool("active", health >= 2);
        healthItem3.SetBool("active", health >= 1);
    }
}