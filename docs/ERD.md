# ER dijagram

```mermaid
erDiagram
    KORISNICI ||--o{ KORISNICKE_ULOGE : ima
    ULOGE ||--o{ KORISNICKE_ULOGE : dodijeljena
    DRZAVE ||--o{ GRADOVI : sadrzi
    GRADOVI ||--o{ KORISNICI : mjesto_prebivalista
    KORISNICI ||--o{ PROFILI_ZAPOSLENIKA : ima
    KATEGORIJE_USLUGA ||--o{ USLUGE : grupise
    KATEGORIJE_PROIZVODA ||--o{ PROIZVODI : grupise
    KORISNICI ||--o{ TERMINI : kreira
    USLUGE ||--o{ TERMINI : dostupna_u
    TERMINI ||--o{ REZERVACIJE : rezervisan
    KORISNICI ||--o{ REZERVACIJE : pravi
    STATUSI_REZERVACIJA ||--o{ REZERVACIJE : status
    KORISNICI ||--o{ NARUDZBE : kreira
    STATUSI_NARUDZBI ||--o{ NARUDZBE : status
    NARUDZBE ||--o{ STAVKE_NARUDZBE : sadrzi
    PROIZVODI ||--o{ STAVKE_NARUDZBE : narucen
    NARUDZBE ||--o{ PLACANJA : placena
    STATUSI_PLACANJA ||--o{ PLACANJA : status
    PLACANJA ||--o{ POVRATI_NOVCA : ima
    KORISNICI ||--o{ RECENZIJE : pise
    USLUGE ||--o{ RECENZIJE : ocijenjena
    PROIZVODI ||--o{ RECENZIJE : ocijenjen
    KORISNICI ||--o{ NOVOSTI : objavljuje
    KORISNICI ||--o{ GALERIJA_SLIKA : dodaje
    KORISNICI ||--o{ NOTIFIKACIJE : prima
    KORISNICI ||--o{ SIGNALI_PREPORUKE : generise
    KORISNICI ||--o{ AUDIT_ZAPISI : izvrsava
```

Ovaj ER dijagram predstavlja pocetni plan baze podataka za aplikaciju eBeautySalon. Tokom implementacije se moze dopuniti, ali mora ostati uskladjen sa pravilima predmeta.
