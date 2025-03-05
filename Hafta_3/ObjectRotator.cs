using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    // Döndürme hızı
    [SerializeField] private float rotationSpeed = 50f;
    
    // Dönüş durumu
    private bool isRotating = false;
    
    // Update is called once per frame
    void Update()
    {
        // Eğer Space tuşuna basılırsa dönme durumunu değiştir
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRotating = !isRotating;
        }
        
        // Eğer dönme aktifse, objeyi döndür
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
} 