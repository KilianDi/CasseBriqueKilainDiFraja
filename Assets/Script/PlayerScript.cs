using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private float horizontal;
    [SerializeField] private float gauche;
    [SerializeField] private float droite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0);
        if (transform.position.x < gauche)
        {
            transform.position = new Vector2(gauche, transform.position.y);
        }
        if (transform.position.x > droite)
        {
            transform.position = new Vector2(droite, transform.position.y);
        }


    }
}
