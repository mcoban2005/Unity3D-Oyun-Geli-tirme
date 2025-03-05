# 3D Platform Oyunu Örnek Projesi

Bu örnek proje, oluşturduğumuz `PlayerController` scriptini kullanarak basit bir 3D platform oyununun nasıl yapılacağını göstermektedir.

## Proje Özellikleri
- First-person (birinci şahıs) karakter kontrolü
- WASD ile hareket
- Mouse ile etrafı görüntüleme
- Space tuşu ile zıplama
- Fizik tabanlı etkileşimler

## Kurulum Adımları

### 1. Yeni Proje Oluşturma
1. Unity Hub'ı açın
2. "New Project" seçin
3. 3D Core template'ini seçin
4. Projeye bir isim verin (örn: "PlatformGame")
5. "Create project" tıklayın

### 2. Sahne Hazırlığı
1. Zemin oluşturma:
   - Hierarchy > Create > 3D Object > Plane
   - Scale: (5, 1, 5) yapın
   - Tag'ini "Ground" olarak ayarlayın

2. Platform oluşturma:
   - Hierarchy > Create > 3D Object > Cube
   - Position: (3, 1, 3)
   - Scale: (2, 0.5, 2)
   - Tag'ini "Ground" olarak ayarlayın
   - Bu platformu çoğaltarak farklı yerlere yerleştirin

### 3. Karakter Oluşturma
1. Player objesi:
   - Hierarchy > Create > 3D Object > Capsule
   - İsmi "Player" olarak değiştirin
   - Position: (0, 1, 0)

2. Kamera ayarları:
   - Main Camera'yı Player'ın child objesi yapın
   - Local Position: (0, 0.6, 0)
   - Rotation: (0, 0, 0)

### 4. Script Ekleme
1. `PlayerController.cs` scriptini Player objesine ekleyin
2. Inspector'da değerleri ayarlayın:
   - Move Speed: 5
   - Jump Force: 5
   - Rotation Speed: 90

### 5. Fizik Ayarları
1. Player objesinin Rigidbody ayarları:
   - Freeze Rotation: X ve Z eksenlerini işaretleyin
   - Mass: 1
   - Drag: 1
   - Angular Drag: 0.5

## Oynanış Mekanikleri

### Karakter Kontrolü
- **W**: İleri hareket
- **S**: Geri hareket
- **A**: Sola hareket
- **D**: Sağa hareket
- **Mouse**: Etrafı görüntüleme
- **Space**: Zıplama

### Fizik Etkileşimleri
- Karakter yerçekimine tabidir
- Platformlar üzerinde zıplayabilir
- Platformlardan düşebilir

## Geliştirme İpuçları

### Script Özelleştirme
1. Hız ayarları:
   - `moveSpeed` değerini artırarak/azaltarak hareket hızını ayarlayın
   - `jumpForce` değerini değiştirerek zıplama yüksekliğini ayarlayın
   - `rotationSpeed` ile dönüş hızını kontrol edin

2. Yeni özellikler eklemek için:
   - Double jump için yeni bir boolean değişken ekleyin
   - Koşma için shift kontrolü ekleyin
   - Eğilme için ctrl kontrolü ekleyin

### Hata Ayıklama
1. Yaygın sorunlar ve çözümleri:
   - Karakter düşmüyorsa: Rigidbody ayarlarını kontrol edin
   - Zıplama çalışmıyorsa: Ground tag'ini kontrol edin
   - Hareket pürüzlüyse: Time.deltaTime kullanımını kontrol edin

## Projeyi Genişletme Fikirleri

### Yeni Özellikler
1. Toplama mekanikleri:
   - Coin'ler ekleyin
   - Skor sistemi oluşturun
   - UI elemanları ekleyin

2. Engeller:
   - Hareket eden platformlar
   - Zarar veren objeler
   - Checkpoint sistemi

3. Ses efektleri:
   - Zıplama sesi
   - Yürüme sesi
   - Coin toplama sesi

### Görsel İyileştirmeler
1. Materyal ve dokular:
   - Zemin ve platformlar için materyaller
   - Karakter için materyal
   - Skybox değiştirme

2. Partikül efektleri:
   - Zıplama efekti
   - Koşma tozu
   - Coin toplama efekti

## Test ve Optimizasyon
1. Performans kontrolü:
   - Frame rate kontrolü
   - Fizik hesaplamalarını optimize etme
   - Işıklandırma ayarları

2. Oynanış testi:
   - Kontrollerin tepki süresi
   - Zıplama mesafelerinin dengesi
   - Platform yerleşimlerinin zorluğu 