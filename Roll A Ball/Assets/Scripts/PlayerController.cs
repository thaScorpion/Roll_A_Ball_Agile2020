using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 movement;
    private int collectablesCount;

    public Text textWin;
    public Text textCount;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        collectablesCount = 0;
        SetTextCount();
    }

    private void Start()
    {
        textWin.enabled = false;
    }

    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        movement.Normalize();
    }

    private void FixedUpdate()
    {
        rb.AddForce(movement * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            collectablesCount++;
            if (collectablesCount >= 8) DisplayWin();
            SetTextCount();
        }
    }

    private void DisplayWin()
    {
        textWin.enabled = true;
        textWin.text = "You Win !!";
    }
    private void SetTextCount()
    {
        textCount.text = "Count : " + collectablesCount.ToString();
    }
}
