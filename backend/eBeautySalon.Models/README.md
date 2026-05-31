# eBeautySalon.Models

Ovdje se nalaze DTO, request i response modeli.

Modeli ne smiju biti isti kao EF entity klase koje se direktno cuvaju u bazi.

## Planirani entiteti

Dokumentacija je napisana na bosanskom jeziku, dok se u kodu po potrebi mogu koristiti standardni engleski nazivi klasa.

| Entitet | Svrha |
|---|---|
| Korisnik | Osnovni podaci o korisnicima sistema |
| Uloga | Korisnicke uloge |
| KorisnikUloga | Veza korisnika i uloga |
| ProfilZaposlenika | Dodatni podaci o zaposlenicima |
| Drzava | Referentni podatak za drzave |
| Grad | Referentni podatak za gradove |
| Usluga | Usluge beauty salona |
| KategorijaUsluge | Kategorije usluga |
| Proizvod | Proizvodi dostupni u salonu |
| KategorijaProizvoda | Kategorije proizvoda |
| Termin | Dostupni termini za rezervaciju |
| Rezervacija | Rezervacije termina |
| StatusRezervacije | Statusi rezervacije |
| Narudzba | Narudzbe proizvoda |
| StavkaNarudzbe | Proizvodi unutar narudzbe |
| StatusNarudzbe | Statusi narudzbe |
| Placanje | Evidencija placanja |
| StatusPlacanja | Statusi placanja |
| PovratNovca | Evidencija refund logike |
| Recenzija | Ocjene i komentari korisnika |
| SlikaGalerije | Slike u galeriji salona |
| Novost | Novosti i obavijesti salona |
| Notifikacija | Sistemske notifikacije korisnika |
| SignalPreporuke | Podaci koji ulaze u sistem preporuke |
| AuditZapis | Trag bitnih promjena u sistemu |

## Planirani DTO/request/response modeli

| Model | Svrha |
|---|---|
| LoginRequest | Zahtjev za prijavu korisnika |
| RegisterRequest | Zahtjev za registraciju korisnika |
| AuthResponse | Odgovor nakon uspjesne autentifikacije |
| KorisnikResponse | Prikaz podataka o korisniku |
| KorisnikUpdateRequest | Izmjena korisnickih podataka |
| UslugaInsertRequest | Dodavanje usluge |
| UslugaUpdateRequest | Izmjena usluge |
| UslugaResponse | Prikaz usluge |
| ProizvodInsertRequest | Dodavanje proizvoda |
| ProizvodUpdateRequest | Izmjena proizvoda |
| ProizvodResponse | Prikaz proizvoda |
| RezervacijaInsertRequest | Kreiranje rezervacije |
| RezervacijaStatusUpdateRequest | Promjena statusa rezervacije |
| RezervacijaResponse | Prikaz rezervacije |
| NarudzbaInsertRequest | Kreiranje narudzbe |
| NarudzbaStatusUpdateRequest | Promjena statusa narudzbe |
| NarudzbaResponse | Prikaz narudzbe |
| PlacanjeResponse | Prikaz podataka o placanju |
| NotifikacijaResponse | Prikaz notifikacije |
| PreporukaResponse | Prikaz preporuke sa objasnjenjem |
