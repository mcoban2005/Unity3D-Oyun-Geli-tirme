# Fizik Tabanlı Bowling Oyunu Projesi

Bu projede, Unity'nin fizik motorunu kullanarak basit bir bowling oyunu oluşturacağız.

## 1. Proje Kurulumu

### Yeni Proje Oluşturma
1. Unity Hub'ı açın
2. "New Project" > "3D Core"
3. Proje adı: "BowlingGame"
4. Create project

### Asset Organizasyonu
```
Assets/
  ├── Scripts/
  ├── Materials/
  ├── Prefabs/
  └── Scenes/
```

## 2. Temel Nesneleri Oluşturma

### Bowling Pisti
1. Zemin oluşturma:
   - Create > 3D Object > Plane
   - Scale: (1, 1, 3)
   - Material: Lane Material (kahverengi)

2. Kenar bariyerleri:
   - Create > 3D Object > Cube
   - Scale: (0.1, 0.2, 3)
   - Duplicate için Ctrl+D
   - Position: Pistin iki yanına yerleştirin

### Bowling Topu
```csharp
public class BowlingBall : MonoBehaviour
{
    [SerializeField] private float throwForce = 1000f;
    private Rigidbody rb;
    private bool isThrown = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isThrown && Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
        }
    }

    void ThrowBall()
    {
        isThrown = true;
        rb.AddForce(Vector3.forward * throwForce);
        rb.AddTorque(Vector3.right * throwForce / 2);
    }
}
```

### Bowling Pinleri
1. Pin prefab oluşturma:
   - Create > 3D Object > Capsule
   - Scale: (0.3, 0.8, 0.3)
   - Rigidbody ekleyin
   - Capsule Collider ayarlayın

2. Pin yerleşimi scripti:
```csharp
public class PinSetup : MonoBehaviour
{
    [SerializeField] private GameObject pinPrefab;
    private Vector3[,] pinPositions = new Vector3[4, 4];
    
    void Start()
    {
        SetupPins();
    }
    
    void SetupPins()
    {
        float spacing = 0.8f;
        int row = 0;
        int pin = 0;
        
        for (int z = 0; z < 4; z++)
        {
            for (int x = 0; x <= z; x++)
            {
                Vector3 position = new Vector3(
                    (x - z/2f) * spacing,
                    1f,
                    20f + z * spacing
                );
                Instantiate(pinPrefab, position, Quaternion.identity);
            }
        }
    }
}
```

## 3. Fizik Ayarları

### Rigidbody Ayarları
1. Bowling Topu:
   - Mass: 7
   - Drag: 0.5
   - Angular Drag: 0.5
   - Collision Detection: Continuous

2. Pinler:
   - Mass: 1
   - Drag: 0.5
   - Angular Drag: 0.5
   - Collision Detection: Continuous

### Physics Material
1. Bowling Pisti:
   - Static Friction: 0.2
   - Dynamic Friction: 0.2
   - Bounciness: 0.1

2. Bowling Topu:
   - Static Friction: 0.3
   - Dynamic Friction: 0.3
   - Bounciness: 0.3

## 4. Skor Sistemi

### Pin Kontrol Scripti
```csharp
public class PinController : MonoBehaviour
{
    private bool isKnockedDown = false;
    private Vector3 startPosition;
    private Quaternion startRotation;
    
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }
    
    void Update()
    {
        if (!isKnockedDown && IsKnockedDown())
        {
            isKnockedDown = true;
            GameManager.Instance.AddScore();
        }
    }
    
    bool IsKnockedDown()
    {
        return Vector3.Angle(Vector3.up, transform.up) > 45f;
    }
    
    public void Reset()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        isKnockedDown = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
```

### Game Manager
```csharp
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    private int throwsLeft = 2;
    
    void Awake()
    {
        Instance = this;
    }
    
    public void AddScore()
    {
        score++;
        UpdateUI();
    }
    
    public void ResetFrame()
    {
        throwsLeft = 2;
        score = 0;
        ResetPins();
        ResetBall();
    }
}
```

## 5. Kullanıcı Arayüzü

### UI Elemanları
1. Skor göstergesi
2. Kalan atış sayısı
3. Reset butonu
4. Güç göstergesi

## 6. Efektler ve Sesler

### Ses Efektleri
1. Top yuvarlanma sesi
2. Pin düşme sesi
3. Strike sesi

### Partikül Efektleri
1. Pin çarpışma efekti
2. Strike efekti

## 7. Test ve Optimizasyon

### Test Edilecek Durumlar
1. Top atış mekaniği
2. Pin fizik tepkileri
3. Skor hesaplama
4. Performans kontrolü

### Optimizasyon
1. Physics.autoSimulation ayarı
2. Collision matrix düzenleme
3. Fixed timestep ayarı

## 8. İleri Seviye Özellikler

### Önerilen Eklemeler
1. Farklı top tipleri
2. Spin mekanikleri
3. Çoklu oyuncu desteği
4. Liderlik tablosu
5. Özel efektler 