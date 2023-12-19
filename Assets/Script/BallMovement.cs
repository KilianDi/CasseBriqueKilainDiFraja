using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float ballForce;
    [SerializeField] private Transform raquette;
    private bool gameStarted = false;
    public static BallMovement instance;

    //Ajoute de la force à la balle
    private void Start()
    {
        rb.AddForce(new Vector2(ballForce, ballForce));
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    //En début de partie la balle est collé au joueur et part que quan un input est appelé
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

    public void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.SetParent(raquette);
        transform.localPosition = Vector3.zero;
        gameStarted = false;
    }

    public void AddForce()
    {
        rb.velocity*=2;
    }
}
