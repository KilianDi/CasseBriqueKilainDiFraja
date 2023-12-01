using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 0f;

    //Application de vélocité pour que le joueur aille à gauche
    private void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    //Application de vélocité pour que le joueur aille à droite
    private void MoveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    //Quand le joueur ne bouge pas sa vélocité est à 0
    private void Stop()
    {
        rb.velocity = Vector2.zero;
    }


    //Appel des méthodes pour permettre au joueur de bouger
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (x < 0f)
        {
            MoveLeft();
        }

        if (x > 0f)
        {
            MoveRight();
        }

        if (x == 0f)
        {
            Stop();
        }

    }
}
