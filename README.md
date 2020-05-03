# PI20-065 CineManage

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Bruno Mataušić | bmatausic@foi.hr | 0016125251 | BrunoM223
Robert Langus | rlangus@foi.hr | 0016122793 | DigitalDevelooper
Luka Zrinski | lzrinski@foi.hr | 0016131570 | Zrinski34
Tomislav Lukežić | tlukezic@foi.hr | 0016123418 | TLukezic

## Opis domene
'CineManage' omogućuje upravljanje podacima vezanih uz kino te prodaju i evidenciju za korisnike i administratore.     

## Specifikacija projekta
Samom pristupu aplikaciji korisnik će moći pregledati popis filmova koji se trenutno prikazuju u kinu sa svim informacijama vezano uz isti, odnosno server će mu poslužiti te podatke. Ukoliko se korisnik odluči na kupnju karata za određeni film tada će se serveru poslati zahtjev za verifikacijom identiteta odnosno ukoliko korisnik nije registriran bit će upućen odgovor sa servera da se registrira kako bi mogao obaviti kupnju do kraja. Također ukoliko se administrator odluči raditi izmjene filmova bit će kontaktiran server radi verifikacije. Kasnije će server slati obavijesti kao podsjetnik klijentu vezano za njegove kupljene ulaznice.

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristup programu potrebnba je autentifikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom korisnikovog zahtjeva za prijavom | Bruno Mataušić
F02 | Pregled filmova i prikazivanja | Korisnik može pregledavati katalog filmova koji se trenutno prikazuju, te odabrati filmove kako bi pogledao vremena prikazivanja | Luka Zrinski
F03 | Kupovina i rezervacija karata | Kada korisnik odabere vrijeme prikazivanja odredenog filma, nakon toga će moći i rezervirati ili kupiti kartu | Bruno Mataušić
F04 | Dodavanje, brisanje i ažuriranje podataka | Osoba koja se prijavi administratorskim podacima moći će upravljati podacima o aktivnim filmovima, prikazivanjima, itd. | Tomislav Lukežić
F05 | Vođenje obračuna | Podaci o cijenama i broju prodanih ulaznica | Luka Zrinski
F06| Podsjetnik za film | Ako korisnik ima kupljen ili rezerviran film, kod ulogiravanja će se pojaviti podsjetnik o navedenom filmu | Robert Langus
F07| Kreiranje naprednih PDF izvješća | Na temelju podataka o poslovanju kreiraju se PDF izvješća | Tomislav Lukežić
F08| Korištenje grafova i drugih vizualnih prikaza podataka | Na temelju podataka o poslovanju kreiraju se grafovi za vizualni prikaz poslovanja | Robert Langus

## Tehnologije i oprema
* Visual Studio
* Visual Paradigm
* Draw.io
* Microsoft Project
* 4 računala s Windows operacijskim sustavom
