using UnityEngine;

public class CollisionAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Obtener el componente Animator del personaje
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            animator.SetTrigger("CollideTrigger");
        }
    }
}
