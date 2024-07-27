using UnityEngine;

public class MoverWASD : MonoBehaviour
{
    public Control control;

    public float velocidadMovimiento = 5f;

    public float fuerzaSalto = 10f;
    public float fuerzaSaltoTrampolin = 20f;

    public float longitudRayo = 1.1f;

    private Rigidbody2D rb;

    public bool tieneControl = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!tieneControl)
        {
            return;
        }

        float movimientoHorizontal = 0f;
        if (Input.GetKey(control.teclaMoverDerecha))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            movimientoHorizontal = 1f;
        }
        else if (Input.GetKey(control.teclaMoverIzquierda))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            movimientoHorizontal = -1f;
        }

        Vector3 nuevaPosicion = transform.position + new Vector3(movimientoHorizontal, 0, 0) * velocidadMovimiento * Time.deltaTime;

        transform.position = nuevaPosicion;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRayo);
        //Debug.DrawRay(transform.position, Vector2.down * longitudRayo, Color.red);

        if (hit.collider != null)
        {
            if (rb.velocity.y == 0 && Input.GetKeyDown(control.teclaSalto))
            {
                Debug.Log("jump");
                rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            }
            else if (hit.collider.CompareTag("Trampolin"))
            {
                rb.velocity = new Vector2(rb.velocity.x, fuerzaSaltoTrampolin);
            }
        }
    }
}