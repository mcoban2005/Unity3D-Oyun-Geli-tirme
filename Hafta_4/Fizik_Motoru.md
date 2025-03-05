# Unity Fizik Motoru ve Çarpışma Sistemleri

## 1. Fizik Motoru Temelleri

### Rigidbody Bileşeni
- Fizik simülasyonu için temel bileşen
- Kütle, sürtünme ve hız özelliklerini kontrol eder
- Yerçekimi etkileşimini sağlar

#### Önemli Özellikler
- **Mass**: Nesnenin kütlesi
- **Drag**: Hava direnci
- **Angular Drag**: Dönüş direnci
- **Use Gravity**: Yerçekimi etkisi
- **Is Kinematic**: Fizik motorundan bağımsız hareket

### Fizik Materyalleri (Physics Material)
- Sürtünme katsayısı
- Zıplama katsayısı
- Yüzey özellikleri

## 2. Çarpışma Algılama (Collision Detection)

### Collider Tipleri
1. **Box Collider**
   - Küp şeklinde çarpışma alanı
   - Basit nesneler için ideal

2. **Sphere Collider**
   - Küresel çarpışma alanı
   - Yuvarlak nesneler için uygun

3. **Capsule Collider**
   - Kapsül şeklinde çarpışma alanı
   - Karakter kontrolü için ideal

4. **Mesh Collider**
   - Karmaşık modeller için özel çarpışma alanı
   - Performans açısından dikkatli kullanılmalı

### Trigger Sistemi
- **Is Trigger** özelliği
- Fiziksel tepki olmadan çarpışma algılama
- Tetikleme olayları:
  - OnTriggerEnter
  - OnTriggerStay
  - OnTriggerExit

### Çarpışma Olayları
```csharp
void OnCollisionEnter(Collision collision)
{
    // Çarpışma başladığında
}

void OnCollisionStay(Collision collision)
{
    // Çarpışma devam ederken
}

void OnCollisionExit(Collision collision)
{
    // Çarpışma bittiğinde
}
```

## 3. Yerçekimi ve Kuvvetler

### Yerçekimi Ayarları
- Project Settings > Physics
- Gravity değeri (varsayılan: -9.81)
- Global veya nesne bazlı ayarlama

### Kuvvet Uygulama Yöntemleri
```csharp
// Anlık kuvvet
rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

// Sürekli kuvvet
rigidbody.AddForce(direction * force);

// Tork (dönme kuvveti)
rigidbody.AddTorque(Vector3.up * torqueForce);
```

### ForceMode Tipleri
- **Force**: Sürekli kuvvet
- **Impulse**: Anlık kuvvet
- **Acceleration**: Kütle bağımsız ivme
- **VelocityChange**: Kütle bağımsız hız değişimi

## 4. Fizik Optimizasyonu

### Performans İpuçları
1. Collider Optimizasyonu
   - Basit collider'ları tercih edin
   - Mesh Collider'ı dikkatli kullanın
   - Convex Mesh özelliğini gerektiğinde kullanın

2. Rigidbody Ayarları
   - Sleeping Mode kullanımı
   - Interpolate özelliği
   - Collision Detection mode seçimi

3. Layer-Based Collision
   - Physics Layer Matrix kullanımı
   - Gereksiz çarpışmaları engelleme

## 5. Fizik Raycast Sistemi

### Raycast Kullanımı
```csharp
RaycastHit hit;
if (Physics.Raycast(origin, direction, out hit))
{
    // Işın bir nesneye çarptı
    Debug.Log("Hit object: " + hit.collider.name);
}
```

### Raycast Tipleri
- **Raycast**: Tek ışın
- **SphereCast**: Küresel ışın
- **BoxCast**: Kutu şeklinde ışın
- **CapsuleCast**: Kapsül şeklinde ışın

## 6. Debug Araçları

### Görsel Debug
```csharp
// Raycast görselleştirme
Debug.DrawRay(origin, direction, Color.red);

// Çarpışma noktası görselleştirme
Debug.DrawLine(hit.point, hit.point + hit.normal, Color.green);
```

### Physics Debug
- Scene view'da collider'ları görüntüleme
- Rigidbody özellikleri inceleme
- Physics Debugger kullanımı 