# Unity3D'de Scripting Temelleri

## 1. C# Programlama Dili Temelleri

### Temel Veri Tipleri
- `int`: Tam sayılar
- `float`: Ondalıklı sayılar
- `bool`: Mantıksal değerler
- `string`: Metin
- `Vector3`: 3D vektör
- `Quaternion`: Rotasyon

### Değişken Tanımlama
```csharp
public int health = 100;
private float speed = 5.0f;
[SerializeField] string playerName;
```

### Operatörler
- Aritmetik: `+`, `-`, `*`, `/`, `%`
- Karşılaştırma: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Mantıksal: `&&`, `||`, `!`

### Kontrol Yapıları
```csharp
if (health <= 0) {
    GameOver();
}

for (int i = 0; i < 10; i++) {
    SpawnEnemy();
}

while (isPlaying) {
    UpdateGame();
}
```

## 2. MonoBehaviour Yaşam Döngüsü

### Temel Event Fonksiyonları
1. **Awake()**
   - Script ilk yüklendiğinde çalışır
   - Değişken başlatma için ideal
   - Diğer scriptlerden önce çalışır

2. **Start()**
   - İlk frame'den önce çalışır
   - Başlangıç değerlerini atama
   - Diğer objelerle iletişim kurma

3. **Update()**
   - Her frame'de çalışır
   - Input kontrolü
   - Sürekli güncelleme gereken işlemler

4. **FixedUpdate()**
   - Fizik hesaplamaları için
   - Sabit zaman aralıklarında çalışır
   - Hareket ve kuvvet uygulamaları

5. **LateUpdate()**
   - Update'den sonra çalışır
   - Kamera takibi
   - Son düzenlemeler

### Örnek Yaşam Döngüsü Script'i
```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Awake()
    {
        // Component referanslarını al
    }

    void Start()
    {
        // Başlangıç değerlerini ayarla
    }

    void Update()
    {
        // Input kontrolü
        // Hareket mantığı
    }

    void FixedUpdate()
    {
        // Fizik tabanlı hareketler
    }

    void LateUpdate()
    {
        // Kamera takibi
    }
}
```

## 3. Component Tabanlı Yapı

### Component Erişimi
```csharp
// Direkt erişim
Rigidbody rb = GetComponent<Rigidbody>();

// Child objeden erişim
Animator anim = GetComponentInChildren<Animator>();

// Parent objeden erişim
Canvas canvas = GetComponentInParent<Canvas>();

// Tüm componentleri alma
Component[] components = GetComponents<Component>();
```

### GameObject İşlemleri
```csharp
// Yeni obje oluşturma
GameObject newObject = new GameObject("ObjectName");

// Obje bulma
GameObject player = GameObject.Find("Player");

// Tag ile bulma
GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

// Component ekleme
Rigidbody rb = gameObject.AddComponent<Rigidbody>();
```

## 4. Input Sistemi

### Klavye ve Mouse Input
```csharp
// Tuş basılı tutulduğunda
if (Input.GetKey(KeyCode.Space))
    Jump();

// Tuşa basıldığında (bir kez)
if (Input.GetKeyDown(KeyCode.E))
    Interact();

// Tuş bırakıldığında
if (Input.GetKeyUp(KeyCode.R))
    ReloadWeapon();
```

### Axis Input
```csharp
float horizontal = Input.GetAxis("Horizontal"); // -1 ile 1 arası
float vertical = Input.GetAxis("Vertical");

Vector3 movement = new Vector3(horizontal, 0, vertical);
```

### Mouse Input
```csharp
// Mouse pozisyonu
Vector3 mousePos = Input.mousePosition;

// Mouse butonu
if (Input.GetMouseButton(0)) // Sol tık
    Shoot();

// Mouse wheel
float scroll = Input.GetAxis("Mouse ScrollWheel");
```

## 5. Debug Araçları

### Debug.Log Kullanımı
```csharp
Debug.Log("Normal log mesajı");
Debug.LogWarning("Uyarı mesajı");
Debug.LogError("Hata mesajı");
```

### Debug.DrawLine ve Ray
```csharp
Debug.DrawLine(start, end, Color.red, duration);
Debug.DrawRay(origin, direction, Color.green);
```

### Gizmos Kullanımı
```csharp
void OnDrawGizmos()
{
    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(transform.position, radius);
}
```

## Pratik Alıştırmalar

### Alıştırma 1: Karakter Hareketi
1. Yeni bir script oluştur: `PlayerMovement.cs`
2. Karakter hızını ayarlamak için değişken tanımla
3. Input ile hareket kontrolü ekle
4. Karakteri hareket ettir

### Alıştırma 2: Obje Etkileşimi
1. Trigger kullanarak obje toplama
2. Skor sistemi oluşturma
3. UI güncelleme
4. Ses efekti ekleme

## Haftalık Ödev
1. Basit bir top oyunu oluşturma
   - Top kontrolü
   - Engeller
   - Skor sistemi
   - Temel UI

2. Gereksinimler:
   - En az 3 farklı script
   - Input kontrolü
   - Fizik etkileşimleri
   - UI elementleri

## Ek Kaynaklar
- Unity Scripting API
- Unity Learn - Scripting Tutorials
- Unity Forum - Scripting Section
- GitHub örnek projeler 