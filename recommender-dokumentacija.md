# Sistem preporuke

## Pristup

U aplikaciji eBeautySalon planiran je content-based sistem preporuke. Preporuke se generisu na osnovu karakteristika proizvoda i usluga, kao i stvarnih korisnickih aktivnosti unutar aplikacije.

## Podaci koji ulaze u preporuke

Sistem koristi sljedece signale:

- kategorija proizvoda
- kategorija usluge
- opis proizvoda ili usluge
- prethodni pregledi proizvoda i usluga
- prethodne rezervacije korisnika
- prethodne narudzbe korisnika
- ocjene i recenzije

Ovi podaci se stvarno upisuju u bazu kroz tabele kao sto su `RecommendationSignals`, `Reservations`, `Orders`, `OrderItems` i `Reviews`.

## Scoring

Svaki kandidat za preporuku dobija bodove na osnovu slicnosti sa korisnikovim prethodnim aktivnostima.

Primjer bodovanja:

- ista kategorija proizvoda ili usluge: +40
- slicne kljucne rijeci u opisu: +20
- korisnik je ranije pregledao slican sadrzaj: +15
- korisnik je ranije narucio proizvod iz iste kategorije: +20
- proizvod ili usluga ima dobru prosjecnu ocjenu: +5

Svi signali koji se evidentiraju koriste se u bodovanju.

## Objasnjive preporuke

Svaka preporuka korisniku prikazuje razlog preporuke.

Primjeri:

```text
Preporuceno jer ste ranije rezervisali uslugu iz kategorije "Njega lica".
```

```text
Preporuceno jer ste kupovali proizvode iz kategorije "Manikura".
```

```text
Preporuceno jer ima slican opis uslugama koje ste ranije pregledali.
```

## Uskladjenost sa implementacijom

Implementacija sistema preporuke mora odgovarati ovoj dokumentaciji. Ako se tokom razvoja promijeni algoritam, ova dokumentacija ce biti azurirana prije finalne predaje.
