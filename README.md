# eBeautySalon

Seminarski rad iz predmeta Razvoj softvera II.

Student: Ajla Baltic  
Indeks: IB180135  
Baza podataka: 180135

## Opis

eBeautySalon je sistem za upravljanje radom beauty salona. Sistem se sastoji od REST API servisa, Flutter desktop aplikacije za administraciju, Flutter mobilne aplikacije za klijente i posebnog worker servisa za asinhronu obradu notifikacija putem RabbitMQ-a.

Desktop aplikacija predstavlja administrativni dio sistema i koristi se za upravljanje zaposlenicima, uslugama, proizvodima, terminima, rezervacijama, narudzbama, galerijom, novostima i izvjestajima.

Mobilna aplikacija predstavlja klijentski dio sistema i koristi se za pregled usluga i proizvoda, rezervaciju termina, pregled historije aktivnosti, narudzbe, placanje, profil, recenzije, notifikacije i preporuke.

## Funkcionalnosti prema prihvacenoj temi

Desktop dio aplikacije zadrzava module iz prihvacene prijave:

- Upravljanje terminima
- Upravljanje rezervacijama
- Upravljanje proizvodima
- Upravljanje narudzbama
- Upravljanje galerijom
- Upravljanje novostima
- Upravljanje cjenovnikom
- Upravljanje historijom
- Generiranje izvjestaja

Mobilni dio aplikacije zadrzava module iz prihvacene prijave:

- Pregled naslovne strane
- Rezervacija termina
- Moje rezervacije
- Pregled trgovine i proizvoda
- Moja korpa
- Pregled galerije
- Ocjenjivanje usluge
- Moje narudzbe
- Sistem preporuke

U odnosu na raniju prijavu i vodic kroz eSpaCenter, implementacija se prosiruje novim pravilima: JWT autentifikacija, role-based autorizacija, statusna logika rezervacija i narudzbi, RabbitMQ worker servis, server-side placanje/refund ako payment ostaje u temi, obavezna paginacija, validacije, centralizovana konfiguracija kroz `.env` i obavezna dokumentacija recommendera.

## Planirana struktura projekta

```text
backend/
  eBeautySalon.API/
  eBeautySalon.Services/
  eBeautySalon.Models/
  eBeautySalon.Worker/
UI/
  eBeautySalon_mobile/
  eBeautySalon_desktop/
docs/
  ERD.md
  database-schema.md
  funkcionalnosti-prihvacene-teme.md
docker-compose.yml
recommender-dokumentacija.md
```

## Tehnologije

- C# / .NET REST API
- Entity Framework Core
- SQL Server
- Flutter mobile
- Flutter desktop Windows
- RabbitMQ
- Docker Compose
- JWT autentifikacija i autorizacija

## Pokretanje aplikacije

Konfiguracijski podaci se cuvaju u `.env` datoteci koja se ne postavlja direktno na GitHub. Za predaju rada koristi se `.env-tajne.zip`.

```bash
docker-compose build
docker-compose up
```

Desktop aplikacija:

```bash
cd UI/eBeautySalon_desktop
flutter pub get
flutter run -d windows --dart-define=API_BASE_URL=http://localhost:5000
```

Mobilna aplikacija:

```bash
cd UI/eBeautySalon_mobile
flutter pub get
flutter run --dart-define=API_BASE_URL=http://10.0.2.2:5000
```

## Korisnicki podaci za testiranje

| Kontekst | Korisnicko ime | Lozinka |
|---|---|---|
| Desktop verzija | desktop | test |
| Mobilna verzija | mobile | test |
| Vise korisnickih uloga | admin | test |

## Napomena

Tema eBeautySalon je prethodno prihvacena. Implementacija se radi u skladu sa novim pravilima: JWT autentifikacija, konfiguracija kroz `.env`, zaseban RabbitMQ worker servis, statusna logika rezervacija i narudzbi, server-side validacija, paginacija, PDF izvjestaji i dokumentovan sistem preporuke.
