# eBeautySalon - Plan implementacije

## Faza 1 - Arhitektura i baza podataka

- Kreiranje GitHub repozitorija
- Definisanje strukture projekta
- Definisanje SQL Server baze podataka `180135`
- Definisanje glavnih i referentnih entiteta
- Definisanje relacija i stranih kljuceva kroz EF konfiguraciju
- Kreiranje migracija i seed podataka
- Dodavanje testnih korisnika, uloga, usluga, proizvoda, termina, narudzbi i slika

## Faza 2 - REST API

- JWT autentifikacija i autorizacija
- Role-based autorizacija za admin funkcionalnosti
- CRUD operacije za glavne entitete
- CRUD operacije za referentne entitete
- Server-side validacija podataka
- Filteri, pretraga i obavezna paginacija
- Custom exception tipovi i standardizovane greske
- Logovanje gresaka preko `ILogger<T>`
- DTO, request i response modeli

## Faza 3 - Poslovna logika

- Statusna logika za rezervacije
- Statusna logika za narudzbe
- Dozvoljeni prelazi statusa: Pending, Confirmed, Cancelled i Completed
- Provjera zauzetosti termina na backendu
- Provjera duplikata za korisnika i termin
- Audit trag za promjene statusa
- Otkazivanje rezervacije ili narudzbe uz razlog

## Faza 4 - Desktop aplikacija

- Prijava administratora i zaposlenika
- Upravljanje terminima
- Upravljanje rezervacijama
- Upravljanje proizvodima
- Upravljanje narudzbama
- Upravljanje galerijom
- Upravljanje novostima
- Upravljanje cjenovnikom
- Upravljanje historijom
- CRUD forme za referentne podatke
- Minimalno dva PDF izvjestaja

## Faza 5 - Mobilna aplikacija

- Registracija i prijava klijenata
- Pregled naslovne strane
- Pregled usluga
- Rezervacija termina
- Moje rezervacije
- Pregled trgovine i proizvoda
- Moja korpa
- Moje narudzbe
- Pregled galerije
- Ocjenjivanje usluge
- Pregled i izmjena profila
- Reset lozinke
- Notifikacije

## Faza 6 - Sistem preporuke

- Content-based sistem preporuke
- Evidentiranje aktivnosti korisnika
- Koristenje kategorija, opisa, pregleda, rezervacija, narudzbi i recenzija
- Bodovanje preporuka na osnovu stvarnih signala
- Objasnjive preporuke prikazane korisniku
- Uskladjivanje implementacije sa `recommender-dokumentacija.md`

## Faza 7 - RabbitMQ i worker servis

- Kreiranje odvojenog worker projekta
- Pokretanje worker servisa u posebnom Docker kontejneru
- Slanje poruka iz API-ja na RabbitMQ
- Obrada poruka u worker servisu
- Slanje emailova i sistemskih notifikacija
- Retry logika i logovanje gresaka

## Faza 8 - Payment integracija

- Implementacija sandbox payment integracije ako payment ostaje u temi
- Server-side potvrda placanja
- Sprjecavanje visestrukog placanja iste stavke
- Prikaz statusa placanja u aplikaciji
- Refund logika kod otkazivanja placenih narudzbi

## Faza 9 - Docker, testiranje i predaja

- Docker Compose za API, worker, RabbitMQ i bazu podataka
- Testiranje osnovnih funkcionalnosti
- Testiranje Android aplikacije u emulatoru
- Testiranje Windows desktop builda
- Priprema `README.md`
- Priprema `.env-tajne.zip`
- Kreiranje GitHub Release-a
- Slanje tacnog GitHub Release linka i sifre za `.env` ZIP arhivu na DLWMS
