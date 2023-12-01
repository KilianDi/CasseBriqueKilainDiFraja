using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float ballForce;
    private bool gameStarted = false;

    //Ajoute de la force � la balle
    private void Start()
    {
        rb.AddForce(new Vector2(ballForce, ballForce));
    }

    //En d�but de partie la balle est coll� au joueur et part que quan un input est appel�
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false) 
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce (new Vector2(ballForce, ballForce));
            gameStarted = true;
            
        }
    }
}
