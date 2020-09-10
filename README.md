# Játékprogram - (Kő, Papír, Olló)

## Játékmenet 1.0
- [x] A számítógép választ egy lehetőséget
- [x] A felhasználó megad egy lehetőséget
- Nyerés:
	- Kő legyőzi az Ollót
	- A Papír legyőzi a Követ
	- Az Olló legyőzi a Papírt
- [x] A nyerés megállapítását kiszervezzük metódusba
	- Ember nyer()
    - Visszaadott érték -> 0, 1, 2
    - 0: Döntetlen
    - 1:Gép nyer
    - 2:Ember nyer
- [x] Kiírjuk az eredményt
    - Kiírás külön metódusba

## Játékmenet 2.0
- [x]Addig játszunk amíg ki nem lépünk a játékból.
- [x] Statisztika megvalósítása
    - gép,játékos,mennyi menet 
- [x]Eredmények fájlba írása és megjelenítése
    - 1 érték --> menetek száma
    - 2 érték --> játékos győzelmei
    - 3 érték --> gép győzelmei
    - értékek ';'-vel elválasztva

