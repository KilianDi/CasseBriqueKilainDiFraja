using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 0f;

    //Application de v�locit� pour que le joueur aille � gauche
    private void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    //Application de v�locit� pour que le joueur aille � droite
    private void MoveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    //Quand le joueur ne bouge pas sa v�locit� est � 0
    private void Stop()
    {
        rb.velocity = Vector2.zero;
    }


    //Appel des m�thodes pour permettre au joueur de bouger
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
