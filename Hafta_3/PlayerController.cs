using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Karakter özellikleri
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float rotationSpeed = 90f;
    
    // Component referansları
    private Rigidbody rb;
    private bool isGrounded;
    
    // Başlangıçta çalışacak kod
    void Start()
    {
        // Rigidbody component'ini al
        rb = GetComponent<Rigidbody>();
        
        // Cursor'u kilitle
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    // Her frame'de çalışacak kod
    void Update()
    {
        // Hareket inputlarını al
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        // Hareket vektörünü hesapla
        Vector3 movement = transform.forward * verticalInput + transform.right * horizontalInput;
        
        // Karakteri hareket ettir
        transform.position += movement * moveSpeed * Time.deltaTime;
        
        // Mouse ile dönüş
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);
        
        // Zıplama kontrolü
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    
    // Çarpışma kontrolü
    void OnCollisionEnter(Collision collision)
    {
        // Yerle temas kontrolü
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
} 