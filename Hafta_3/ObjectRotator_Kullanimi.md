# Obje Döndürme Scripti Kullanımı

Bu basit script, bir objeyi Space tuşuna basarak sürekli döndürmenizi sağlar.

## Nasıl Kullanılır?

1. Unity'de yeni bir 3D proje açın

2. Sahnede döndürmek istediğiniz objeyi oluşturun:
   - Hierarchy > Create > 3D Object > Cube (veya başka bir obje)

3. `ObjectRotator.cs` scriptini objeye ekleyin:
   - Objeyi seçin
   - Inspector'da "Add Component" butonuna tıklayın
   - Script'i sürükleyip bırakın veya adını yazarak ekleyin

4. (İsteğe bağlı) Inspector'da döndürme hızını ayarlayın:
   - Rotation Speed değerini değiştirerek dönüş hızını artırıp azaltabilirsiniz
   - Varsayılan değer 50'dir

## Kontroller
- **Space**: Dönmeyi başlatır/durdurur

## Özelleştirme İpuçları
- Farklı bir dönme ekseni için `Vector3.up` yerine:
  - X ekseni için `Vector3.right`
  - Z ekseni için `Vector3.forward` kullanabilirsiniz
- Dönüş yönünü değiştirmek için hızı negatif yapabilirsiniz 