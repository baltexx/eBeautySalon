# Plan baze podataka

Baza podataka se zove `180135`.

## Glavne tabele

Ove tabele predstavljaju funkcionalnu jezgru aplikacije i ulaze u minimalni broj glavnih tabela.

| Tabela | Svrha |
|---|---|
| Users | Korisnici sistema |
| EmployeeProfiles | Dodatni podaci o zaposlenicima |
| Services | Usluge beauty salona |
| Products | Proizvodi koji se mogu naruciti |
| AppointmentSlots | Dostupni termini |
| Reservations | Rezervacije termina |
| Orders | Narudzbe proizvoda |
| OrderItems | Stavke narudzbe |
| Payments | Evidencija placanja |
| Refunds | Evidencija povrata novca |
| Reviews | Recenzije i ocjene |
| News | Novosti i obavijesti salona |
| GalleryImages | Slike galerije |
| Notifications | Sistemske notifikacije |
| RecommendationSignals | Signali za sistem preporuke |
| AuditLogs | Audit trag za bitne akcije |

## Referentne tabele

| Tabela | Svrha |
|---|---|
| Roles | Korisnicke uloge |
| UserRoles | Veza korisnika i uloga |
| Countries | Drzave |
| Cities | Gradovi |
| ProductCategories | Kategorije proizvoda |
| ServiceCategories | Kategorije usluga |
| ReservationStatuses | Statusi rezervacija |
| OrderStatuses | Statusi narudzbi |
| PaymentStatuses | Statusi placanja |

## Statusi

Rezervacije i narudzbe koriste definisane statuse:

```text
Pending -> Confirmed -> Completed
Pending -> Cancelled
Confirmed -> Cancelled
```

Hard delete se ne koristi za poslovne procese kao sto su rezervacije i narudzbe.

## Pravila

- Svi referentni podaci se vode kroz FK veze.
- Grad, drzava, kategorija i status nisu string polja nego zasebne tabele.
- Obavezna polja su NOT NULL.
- Svi list endpointi imaju filtere i paginaciju.
- Seed sadrzi testne korisnike, uloge, usluge, proizvode, termine, narudzbe, recenzije i slike.
