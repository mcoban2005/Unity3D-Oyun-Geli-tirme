# Unity 3D'de Terrain İşlemleri

## Terrain (Arazi) Nedir?
Terrain, Unity'de geniş açık dünyalar, dağlar, vadiler ve peyzaj oluşturmak için kullanılan özel bir bileşendir. Terrain sistemi, gerçekçi dış mekan ortamları oluşturmanıza olanak tanır.

## Terrain Oluşturma ve Düzenleme

### Yeni Terrain Oluşturma
1. Hierarchy penceresinde sağ tık > 3D Object > Terrain
2. Terrain otomatik olarak 1000x1000 birimlik bir alan oluşturur
3. Inspector'da Terrain ayarları görünecektir

### Terrain Araçları
1. **Raise / Lower Terrain (Yükselt/Alçalt)**
   - Fırça boyutu ve gücü ayarlanabilir
   - Sol tık yükseltir, Shift + Sol tık alçaltır
   - Yumuşak geçişler için opacity ayarı kullanılır

2. **Paint Height (Yükseklik Boyama)**
   - Belirli bir yüksekliğe göre boyama
   - Hassas yükseklik kontrolü sağlar

3. **Smooth Height (Yumuşatma)**
   - Sert geçişleri yumuşatır
   - Doğal görünüm elde etmek için kullanılır

4. **Stamp Terrain (Damga)**
   - Hazır şekilleri araziye uygular
   - Dağ, vadi gibi formlar oluşturur

## Terrain Dokuları ve Detayları

### Terrain Layers (Arazi Katmanları)
1. **Layer Ekleme**
   - Paint Texture aracını seçin
   - Create Layer'a tıklayın
   - Yeni materyal ve doku seçin

2. **Doku Boyama**
   - Fırça ayarlarını yapın
   - Hedef alanı boyayın
   - Birden fazla doku karıştırılabilir

### Terrain Texture Tipleri
1. **Base Map (Temel Doku)**
   - Arazinin ana dokusu
   - Çim, toprak, kum vb.

2. **Normal Map**
   - Yüzey detayları için
   - 3B görünüm efekti sağlar

3. **Mask Map**
   - Metalik ve pürüzlülük kontrolü
   - İleri seviye görsel efektler

## Ağaç ve Bitki Ekleme

### Ağaç Yerleştirme
1. **Ağaç Ekleme Hazırlığı**
   - Paint Trees aracını seçin
   - Edit Trees > Add Tree
   - Ağaç prefabını seçin

2. **Ağaç Özellikleri**
   - Tree Density (Ağaç Yoğunluğu)
   - Tree Height (Ağaç Yüksekliği)
   - Tree Width (Ağaç Genişliği)
   - Random Rotation (Rastgele Döndürme)

### Bitki ve Çim Ekleme
1. **Detay Ekleme**
   - Paint Details aracını seçin
   - Edit Details > Add Grass Texture
   - Çim/bitki dokusunu seçin

2. **Detay Ayarları**
   - Detail Density (Detay Yoğunluğu)
   - Detail Height (Detay Yüksekliği)
   - Wind Settings (Rüzgar Ayarları)

## Proje 2: Basit Bir Terrain Oluşturma

### Adım 1: Terrain Oluşturma
1. Yeni bir sahne açın
2. Terrain ekleyin
3. Terrain boyutlarını ayarlayın (1000x1000)

### Adım 2: Arazi Şekillendirme
1. Raise/Lower tool ile temel dağlar oluşturun
2. Smooth Height tool ile geçişleri yumuşatın
3. Paint Height tool ile platolar oluşturun

### Adım 3: Doku Ekleme
1. Yeni Terrain Layer oluşturun
   - Çim dokusu
   - Toprak dokusu
   - Kaya dokusu
2. Dokuları uygun bölgelere boyayın
3. Geçişleri doğal görünecek şekilde ayarlayın

### Adım 4: Ağaç ve Bitki Ekleme
1. Ağaç prefabları ekleyin
2. Ağaçları uygun bölgelere yerleştirin
3. Çim ve küçük bitkiler ekleyin
4. Detay yoğunluğunu ayarlayın

### Adım 5: Son Rötuşlar
1. Lighting ayarlarını yapın
2. Ambient Occlusion ekleyin
3. Kamera açılarını ayarlayın
4. Performans optimizasyonu yapın

## Önemli İpuçları
- Terrain boyutunu projenize uygun seçin
- Katmanları mantıklı bir şekilde organize edin
- Düzenli backup alın
- LOD (Level of Detail) ayarlarını optimize edin
- Terrain'i bölümlere ayırarak performansı artırın

## İleri Seviye Konular
- Terrain LOD sistemi
- Procedural Terrain oluşturma
- Height map kullanımı
- Terrain verilerini dışa/içe aktarma
- Terrain performans optimizasyonu 