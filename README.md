<h1 align="center">Power Up Game Jam  Magical Exile</h1>
<div align="center">
  <img src="galerii/düşman.png">





## Magical-Exile
Karabük Üniversitesi Tarafından Düzenlenen Power Up Game jam Yarışmasında 48 Saat İçinde yapılan Oyundur

---
<img src="galerii/düşman.png">








## Antenler
nRF24L01+PA+LNA modüllerinin mesafe performansı için harici antenli versiyonlarının kullanılması şarttır. Antensiz (PCB antenli) modüllerin menzili, engelsiz ortamda dahi 10 metreyi geçmekte zorlanır ve bu modüller jammer gibi uygulamalar için kesinlikle uygun değildir.

Jammer tasarımında, parazit sinyalinin gücünü ve etkinliğini artırmak için çift anten kullanımı yaygın bir yöntemdir. İki anten kullanmak, tek antene kıyasla daha yüksek seviyede ve daha geniş bir alana parazit yayılmasını sağlar. Ayrıca, doğru, uyumlu ve uygun frekansta çalışacak daha büyük bir anten kullanmak, menzili ve sinyal gücünü doğrudan artıracaktır.

---

## 3.Anten
"Bazı ESP32 modellerinde harici anten takılabilir. Yani, nRF24L01+PA+LNA antenlerinden birini, ESP32 üzerindeki dahili PCB antene takabilirsiniz. Bu da ekstra parazit sinyal üretimine ve mesafe artışına katkı sağlayacaktır
<img src="galeri/esp32antenli.jpeg">

---

## Bağlantı şeması
<img src="galeri/jammerfritzing.jpg">





### HSPI
|1. nRF24L01 modül Pimi | HSPI Pimi (ESP32) | 10uf kapasitör |
|---------------|------------------|--------------------|
| VCC           | 3.3V             | (+) kapasitör |
| GND           | GND              | (-) kapasitör |
| CE            | GPIO 16          |
| CSN           | GPIO 15          |
| SCK           | GPIO 14          |
| MOSI          | GPIO 13          |
| MISO          | GPIO 12          |
| IRQ           |                  |

### VSPI 
| 2. nRF24L01 modül Pini | HSPI Pini (ESP32) | 10uf kapasitör |
|---------------|------------------|--------------------|
| VCC           | 3.3V             | (+) kapasitör |
| GND           | GND              | (-) kapasitör |
| CE            | GPIO 22          |
| CSN           | GPIO 21          |
| SCK           | GPIO 18          |
| MOSI          | GPIO 23          |
| MISO          | GPIO 19          |
| IRQ           |                  |



### Oled Ekran pin
| 0.96" OLED Display I2C | ESP32 |
|------------------------|-------|
|          GND           |  GND  |
|          VCC           | 5V  |
|          SCk           |GPIO 33 |
|          SDA           |GPIO 25 |





<h4 align="center">!!Lütfen jammer kullanımının tamamen kendi sorumluluğunuzda olduğunu unutmayın. jammer yalnızca eğitim amaçlıdır ve hiçbir yasa dışı veya etik olmayan faaliyet için kullanılmamalıdır. sinyal kesmek yasa dışıdır ve başınızı büyük belaya sokabilir!</h4>
<h4 align="center">Eylemlerinizden sorumlu değilim!</h4>
