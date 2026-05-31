# Funkcionalnosti prihvacene teme eBeautySalon

Ovaj dokument povezuje ranije prihvacenu temu eBeautySalon sa novim pravilima za implementaciju seminarskog rada.

## Osnova iz prihvacene teme

Tema eBeautySalon ostaje sistem za beauty salon. Implementacija mora biti prilagodjena novim pravilima predmeta i funkcionalnostima iz prethodno prihvacene prijave.

## Desktop aplikacija

Desktop aplikacija je administrativni dio sistema.

Moduli iz prihvacene teme:

| Modul | Opis |
|---|---|
| Upravljanje terminima | Kreiranje, izmjena, pregled i filtriranje termina. |
| Upravljanje rezervacijama | Pregled rezervacija, filtriranje, promjena statusa i otkazivanje uz razlog. |
| Upravljanje proizvodima | CRUD proizvoda, slike, cijene, kategorije i zalihe. |
| Upravljanje narudzbama | Pregled narudzbi, detalji narudzbe, statusi i otkazivanje. |
| Upravljanje galerijom | Dodavanje, izmjena i brisanje slika galerije. |
| Upravljanje novostima | Dodavanje, izmjena i brisanje novosti sa slikom i datumom. |
| Upravljanje cjenovnikom | Upravljanje uslugama i cijenama salona. |
| Upravljanje historijom | Pregled historije narudzbi, rezervacija i placanja. |
| Generiranje izvjestaja | Minimalno dva PDF izvjestaja dostupna za preuzimanje i ispis. |

Dodatno po novim pravilima desktop mora imati CRUD za referentne podatke:

- drzave
- gradovi
- kategorije proizvoda
- kategorije usluga
- statusi rezervacija
- statusi narudzbi
- statusi placanja
- korisnicke uloge

## Mobilna aplikacija

Mobilna aplikacija je klijentski dio sistema.

Moduli iz prihvacene teme:

| Modul | Opis |
|---|---|
| Pregled naslovne strane | Prikaz usluga, novosti i osnovne navigacije. |
| Rezervacija termina | Pregled slobodnih termina i kreiranje rezervacije. |
| Moje rezervacije | Pregled vlastitih rezervacija i otkazivanje aktivnih rezervacija. |
| Pregled trgovine i proizvoda | Pregled proizvoda sa slikom, nazivom, cijenom i detaljima. |
| Moja korpa | Pregled odabranih proizvoda i kreiranje narudzbe. |
| Pregled galerije | Pregled slika salona i radova. |
| Ocjenjivanje usluge | Ostavljanje recenzije i ocjene. |
| Moje narudzbe | Pregled narudzbi, statusa i detalja. |
| Sistem preporuke | Prikaz preporucenih proizvoda/usluga sa objasnjenjem. |

Dodatno po novim pravilima mobilna aplikacija mora imati:

- pregled i izmjenu profila
- reset lozinke
- master-detail prikaz
- notifikacije sa statusom procitano/neprocitano
- confirmation dialog za placanje, otkazivanje i brisanje
- validacije ispod input polja
- dropdown liste za FK podatke

## API

Glavni REST API mora sadrzavati:

- JWT autentifikaciju
- role-based autorizaciju
- CRUD za glavne i referentne entitete
- filtere i pretragu
- obaveznu paginaciju
- server-side validaciju
- standardizovane greske
- logovanje gresaka preko `ILogger<T>`
- DTO/request/response modele
- servisni sloj izmedju kontrolera i DbContext-a
- state machine za rezervacije i narudzbe
- recommender sa objasnjenjima

## Worker servis

Poseban worker servis mora biti odvojen od API-ja i pokrenut kao poseban Docker kontejner.

Worker koristi RabbitMQ za:

- slanje e-maila nakon rezervacije
- slanje obavijesti nakon promjene statusa
- slanje obavijesti nakon placanja
- slanje obavijesti nakon otkazivanja

## Payment napomena

Ako payment ostaje u temi, implementacija mora koristiti stvarni sandbox, npr. Stripe ili PayPal. Placanje se ne smije simulirati i ne smije ga finalizirati klijent. Server mora potvrditi placanje i podrzati refund logiku.

Ako se payment izbacuje ili mijenja iz PayPal u Stripe, potrebno je uskladiti dokumentaciju/prijavu sa profesorom.
