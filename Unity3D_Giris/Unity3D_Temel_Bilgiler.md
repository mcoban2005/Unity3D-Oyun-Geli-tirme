# Unity 3D'ye Giriş

## Unity 3D Nedir?
Unity 3D, oyun geliştirme ve interaktif içerik oluşturma için kullanılan güçlü bir oyun motorudur. 2D ve 3D oyunlar, simülasyonlar, eğitim uygulamaları ve daha fazlasını geliştirebilirsiniz.

## Unity 3D Arayüzü

### Ana Pencereler
1. **Scene View (Sahne Görünümü)**
   - 3D veya 2D sahnenizi düzenlediğiniz ana çalışma alanı
   - Nesneleri yerleştirme, döndürme ve ölçeklendirme işlemlerini yapabilirsiniz
   - Kamera kontrolü: Alt + Sol Tık (Orbit), Alt + Sağ Tık (Zoom)

2. **Game View (Oyun Görünümü)**
   - Oyununuzun nasıl görüneceğini gösteren pencere
   - Play tuşu ile oyununuzu test edebilirsiniz

3. **Hierarchy Window (Hiyerarşi Penceresi)**
   - Sahnenizdeki tüm nesnelerin listesi
   - Nesneler arasında parent-child ilişkisi kurabilirsiniz

4. **Project Window (Proje Penceresi)**
   - Projenizdeki tüm dosyaları görüntüler ve yönetir
   - Materyaller, scriptler, prefablar, sesler vb.

5. **Inspector Window (Denetçi Penceresi)**
   - Seçili nesnenin özelliklerini gösterir ve düzenlemenizi sağlar
   - Component ekleme/çıkarma işlemleri burada yapılır

## Temel Nesneler

### 1. Primitive (İlkel) Nesneler
- Cube (Küp)
- Sphere (Küre)
- Capsule (Kapsül)
- Cylinder (Silindir)
- Plane (Düzlem)
- Quad (Kare)

### 2. Temel Bileşenler (Components)
- **Transform**: Konum, rotasyon ve ölçek bilgilerini içerir
- **Mesh Renderer**: 3D modellerin görüntülenmesini sağlar
- **Collider**: Çarpışma algılama için kullanılır
- **Rigidbody**: Fizik simülasyonu için kullanılır
- **Camera**: Oyun görünümünü belirler
- **Light**: Işık kaynakları oluşturur

## Proje 1: Basit Bir Sahne Oluşturma

### Adım 1: Yeni Proje Oluşturma
1. Unity Hub'ı açın
2. "New Project" butonuna tıklayın
3. 3D template seçin
4. Proje adını ve konumunu belirleyin
5. "Create project" butonuna tıklayın

### Adım 2: Sahne Düzenleme
1. Hierarchy penceresinde sağ tık > 3D Object > Plane ekleyin (zemin olarak)
2. Plane'i (0,0,0) konumuna yerleştirin
3. Yeni bir Cube ekleyin
4. Cube'u (0,0.5,0) konumuna yerleştirin
5. Directional Light'ın açısını ayarlayın

### Adım 3: Materyal Oluşturma ve Uygulama
1. Project penceresinde sağ tık > Create > Material
2. Yeni materyale bir renk atayın
3. Materyali cube üzerine sürükleyip bırakın

### Adım 4: Kamera Ayarları
1. Main Camera'yı seçin
2. Position: (0,1,-10)
3. Rotation: (15,0,0)
4. Field of View: 60

### Adım 5: Test Etme
1. Play tuşuna basın
2. Sahnenizi farklı açılardan kontrol edin
3. Gerekli düzenlemeleri yapın

## İpuçları ve Kısayollar
- **Q**: El aracı (Pan)
- **W**: Taşıma aracı
- **E**: Döndürme aracı
- **R**: Ölçeklendirme aracı
- **F**: Seçili nesneye odaklanma
- **Ctrl + S**: Sahneyi kaydetme
- **Ctrl + Z**: Geri alma
- **Ctrl + Y**: İleri alma

## Sonraki Adımlar
- Script yazma ve C# programlama
- Animasyon oluşturma
- Fizik sistemini kullanma
- Prefab oluşturma ve kullanma
- UI elementleri ekleme 