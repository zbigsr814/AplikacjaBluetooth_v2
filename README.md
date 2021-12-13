# AplikacjaBluetooth_v2
Aplikacja bluetooth do sterowania zdalnym pojazdem.
Komputer musi być wyposażony w przejściówkę USB-BT.
Należy w systemie połączyć się z urządzeniem BLuetooth, w naszym przypadku jest to urządzenie bt123, hasło 1234.
Później można uruchomić program ustawić port COM w którym jest przejściówka USB-BT, bautrate ustawić na 9600.
Jeśli połączenie się powiedzie to można przejść do sekcji sterowania. W tych sekcjach sterujemy ruchem pojazdu.

Wykonany pojazd był wyposażony w 4 koła szweckie. Koła działały niezależnie od siebie. Każde koło miało silnik. Program był napisaby w C na procesorze Atmega8. 
Odbiornikiem sygnału Bluetooth był modół BTM-222. Modół ten przetwarza sygnał BT na RS-232. Następnie ten sygnał odbiera mikrokontroler i steruje ruchem pojazdu.
