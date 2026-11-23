# Projektfeladat-Szallodai-foglalaskezelo
## Feladatmegosztás

#### Szabó Szintia:

- Room osztály,
- szobakezelés,
- szabad szobák keresése,
- árkalkuláció,
- statisztikák egy része.

 #### Árki Dávid:

- Guest osztály,
- Booking osztály,
- foglalások kezelése,
- foglalási ütközések vizsgálata,
- fájlkezelés.

#### Közös feladat:
- főmenü,
- rendszerintegráció,
- tesztelés,
- hibajavítás,
- dokumentáció,
- végső bemutató.

## Alapvető követelmények:

#### A programnak képesnek kell lennie:

- szobák kezelésére
- vendégek kezelésére
- foglalások létrehozására
- foglalások módosítására
- foglalások törlésére
- szabad szobák keresésére
- foglalási ütközések ellenőrzésére
- ár kiszámítására
- adatok fájlba mentésére
- adatok betöltésére
- statisztikák készítésére

## Osztálydiagramm:

#### Room
- RoomNumber
- RoomType
- Capacity
- PricePerNight
- IsActive

#### Guest
- Id
- Name
- Phone
- Email

#### Booking
- Id
- GuestId
- RoomNumber
- CheckIn
- CheckOut
- GuestCount
- Status
- TotalPrice

## Algoritmus:

### 1. INDÍTÁS
   Fájlok betöltése (rooms, guests, bookings)
      ha nincs fájl            -> üres lista
      ha hibás a fájl          -> hibaüzenet, üres lista
   Főmenü megjelenítése
###2. FŐMENÜ (addig megy, amíg be nem zárod)
   Választható: Szobák / Vendégek / Foglalások /
                Szabad szobák / Statisztika / Mentés
### 3. SZOBÁK (vendégeknél ugyanígy, csak más adatokkal)
   Hozzáadás:
      adatok beolvasása
      ha a szobaszám, kapacitás vagy ár nem szám  -> hibaüzenet, vége
      ha kapacitás <= 0 vagy ár < 0               -> hibaüzenet, vége
      szoba hozzáadása a listához, mentés
   Módosítás:  kijelölt szoba adatainak átírása (ugyanazok az ellenőrzések), mentés
   Törlés:     kijelölt szoba törlése a listából, mentés
   Keresés:    szűrés típusra / szobaszámra / felszereltségre
   Összes:     teljes lista újra megjelenítése

### 4. FOGLALÁS LÉTREHOZÁSA
   ha nincs vendég                  -> hibaüzenet, vége
   ha nincs szoba                   -> hibaüzenet, vége
   beolvasás: vendég, szoba, érkezés, távozás, vendégek száma
   ha távozás <= érkezés            -> hibaüzenet, vége
   ha a vendégek száma üres         -> hibaüzenet, vége
   ha a vendégek száma nem szám     -> hibaüzenet, vége
   ha a vendégek száma <= 0         -> hibaüzenet, vége
   szoba megkeresése
   ha nincs ilyen szoba             -> hibaüzenet, vége
   ha vendégek száma > kapacitás    -> hibaüzenet, vége
   ha a szoba foglalt               -> hibaüzenet, vége
   ár = éjszakák száma * éjszakai ár
   új foglalás: Id = legnagyobb Id + 1, státusz = "Aktív"
   hozzáadás a listához, mentés, "Sikeres foglalás"

### 5. ÜTKÖZÉS ELLENŐRZÉSE (foglalt-e a szoba?)
   minden meglévő foglalásra:
      ha ugyanaz a szoba ÉS érkezés < másik távozása ÉS távozás > másik érkezése
         -> foglalt
   ha egyik sem ütközik -> szabad
   (a távozás napján új vendég érkezhet)

### 6. FOGLALÁS TÖRLÉSE
   ha nincs kijelölve foglalás  -> hibaüzenet, vége
   megerősítés kérdés: "Biztosan törölni szeretnéd?"
      Igen -> törlés a listából, mentés
      Nem  -> nem történik semmi

### 7. SZABAD SZOBÁK KERESÉSE
   beolvasás: érkezés, távozás, vendégek száma
   ha nem szám a létszám vagy távozás <= érkezés -> hibaüzenet, vége
   minden szobára:
      ha aktív ÉS kapacitás >= létszám ÉS szabad az időszakban
         -> bekerül az eredménylistába
   eredménylista megjelenítése

### 8. STATISZTIKA
   szobák, vendégek és foglalások számának kiírása

### 9. MENTÉS
   szobák, vendégek és foglalások kiírása fájlba (JSON)


## Fejlesztési terv:

1. hét: 
Github, projekt létrehozása, tervezés
2. hét:
Osztályok elkészítése
3. hét:
Adatok felvétele, módosítása, törlése
4. hét:
Foglalások kezelése
5. hét:
CSV betöltése
6. hét: 
Ár kiszámitás, statisztikák
7. hét:
Legalább 15 tesztelés
8. hét:
Projekt véglegesítése, bemutatás

