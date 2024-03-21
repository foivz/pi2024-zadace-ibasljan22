# Softver za osobnu telemedicinu

## Podaci o studentu

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Ivan Bašljan  | ibasljan22@foi.hr | 0016158450 | ibasljan22


## Opis domene
<br> Potrebno je napraviti softver koji će osobama, ponajviše studentima, olakšati pristup liječnicima opće prakse bez nekakvog čekanja u redu. Softver bi trebao imati više mogućih paketa koji se plaćaju. Ciljana populacija su studenti pa će za njih biti 10% popusta na usluge softvera uz priležeću iskicu, no svatko može koristiti softver.

## Specifikacija projekta
Identifikator | FZ-1
-|-
Zahtjev | Sustav će omogućiti prijavu liječnicima i pacijentima
Obrazloženje | Svaki liječnik i pacijent imati će jedinstveno korisničko ime kojim se prijavljuju uz lozinku koju sami odaberu. Nakon prijave ovisno o ulozi u kojoj se nalazi korisnik, softver će imati različite funkcije za pojedinačnu ulogu. Ako se korisnik prijavi kao pacijent tada će imati sve funkcije koju ima pacijent. Pregledavanje vlastite medicinske povijesti, određenu terapiju, rezultate vlastitih pretraga te stvaranje zahtjeva za pregled. Korisnik koji se prijavi kao pacijent će trebati unijeti podatke kao zdravstvena iskaznica, email za kontakt, broj telefona. Korisnik koji se prijavi kao liječnik opće medicine imat će sve funkcije koje ima liječnik opće medicine nekog pacijenta. Pripadajuće funkcije te uloge su pregled i uređivanje medicinske povijesti pacijenta, uređivanje terapije, rezultate pretraga. Liječnik će trebati unijeti svoj email, broj telefona, radno mjesto. Liječnik će moći vidjeti koliko osoba je njega odabralo, uređivati sam zahtjev za pregledom te će moći vidjeti mail svakog od svojih pacijenata i tako ih kontaktirati vezano uz savjetovanje.
Način provjere | Upis ispravnih korisničkih podataka treba omogućiti prijavu u sustav i daljni rad u sustavu, ovisno o korisniku koji se prijavljuje, pacijent ili liječnik opće medicine.
Prioritet [1-5] | 1
Izvor/Porijeklo | Developer tim aplikacije

Identifikator | FZ-2
-|-
Zahtjev | Sustav će omogućiti pacijentima odabir i pretplatu na jednu od ponuđenih zdravstvenih usluga, pregled na koju su uslugu točno pretplaćeni 
Obrazloženje | Pacijenti odmah čim se ulogiraju u aplikaciju imati će odmah prikazane ponuđene zdravstvene usluge. Pacijentima će biti omogućena fleksibilnost u odabiru paketa koji najbolje odgovaraju njihovim potrebama i financijskim mogućnostima.
Način provjere | Nakon što se pacijenti ulogiraju u aplikaciju trebaju odabrati jedan od ponuđenih medicinskih usluga te dovršiti plaćanje odabrane usluge. Nakon plaćanja pacijent bi trebao vidjeti na koju je točno uslugu pretplaćen.
Prioritet [1-5] | 2
Izvor/Porijeklo | Developer tim aplikacije

Identifikator | FZ-3
-|-
Zahtjev | Sustav će omogućit pacijentima odabir jednog od dostupnih i ugovorenih liječnika te mogućnost slanja zahtjeva za pregled svome liječniku
Obrazloženje | Nakon što se pacijent uspješno prijavi u aplikaciju na početnom ekranu će moći vidjeti svoje medicinske podatke, no isto tako će moći vidjeti listu liječnika na kojoj mora odabrati jednoga, a nakon odabira dobiva opciju za stvaranjem novog zahtjeva za pregled u kojem su sadržani medicinski podaci pacijenta.  
Način provjere | Treba se uspješno prijaviti u aplikaciju te bi se odmah na početnom ekranu trebao odabrati liječnik i nakon toga bi trebala biti otključana opcija stvaranja zahtjeva za pregledom koji se odmah šalje liječniku i u njemu su medicinski podaci pacijenta. 
Prioritet [1-5] | 1
Izvor/Porijeklo | Developer tim aplikacije

Identifikator | FZ-4
-|-
Zahtjev | Sustav će omogućiti pacijentima pregled vlastitih zahtjeva za pregled, pregled medicinskih podataka, uključujući povijest bolesti, alergije, lijekove i laboratorijske nalaze
Obrazloženje | Pacijentima koji se uspješno prijave u aplikaciju pomoću korisničkog imena i lozinke će odmah na početnom ekranu moći vidjeti vlastito zdravstveno stanje uključujući povijest bolesti, alergije, lijekove i laboratorijske nalaze. Moći će vidjeti svoje zahtjeve za pregledom te u njima čitati preporuke, savjete svoga liječnika. 
Način provjere | Trebalo bi se uspješno prijaviti u sustav sa korisničkim imenom i lozinkom nakon toga bi na početnom ekranu trebali vidjeti vlastito zdravstveno stanje uključujući povijest bolesti, alergije, lijekove, laboratorijske nalaze te vidjeti svoje zahtjeve za pregledom te u njima čitati preporuke, savjete svoga liječnika. 
Prioritet [1-5] | 3
Izvor/Porijeklo | Developer tim aplikacije

Identifikator | FZ-5
-|-
Zahtjev | Sustav će omogućiti liječnicima da vide koga imaju za pacijenta te pregled njihovih osobnih i medicinskih podataka 
Obrazloženje | Nakon što se liječnik prijavi u aplikaciju pomoću korisničkog imena i vlastite lozinke na početnom zaslonu će vidjeti sve pacijenata koji su njega odabrali za svoga liječnika na aplikaciji, a ako odabere nekog od pacijenata onda će mu prikazati osobne i medicinske podatke samog pacijetna.  
Način provjere | Liječnik bi se trebao uspješno prijaviti u aplikaciju te bi odmah na početnom zaslonu trebao vidjeti sve svoje pacijente, a kada bi kliknuo na jednog od njih onda bi mu se trebali prikazati osobni i medicinski podaci toga pacijenta.
Prioritet [1-5] | 2
Izvor/Porijeklo | Developer tim aplikacije

Identifikator | FZ-6
-|-
Zahtjev | Sustav će omogućiti liječnicima da uređuju i pregledavaju sve zahtjeve za pregled na temelju rezultata nalaza i razgovora sa pacijentom
Obrazloženje | Liječnici će imati uvid u zahtjev za pregled koji dobije od pacijenta. Moći će uređivati i pisati vlastite bilješke, preporuke na temelju nalaza, pretraga i razgovora sa pacijentom.
Način provjere | Kada se liječnik prijavi u sustav imati će uvid u sve zahtjeve za pregled koje je dobio od svojih pacijenata. U njih će moći pisati preporuke, rezultate nalaza i pretraga te uređivate sve te podatke.
Prioritet [1-5] | 1
Izvor/Porijeklo | Developer tim aplikacije


Identifikator | FZ-7
-|-
Zahtjev | Sustav će omogućiti developer timu aplikacije da ispišu statističke podatke korištenja pojedine medicinske usluge 
Obrazloženje | Developer tim aplikacije ima uvid u sve aspekte same aplikacije te će moći vidjeti koliko korisnika koristi koju medicinsku uslugu.
Način provjere | Član developer tima bi se trebao prijaviti u aplikaciju preko admin korisničkog imena i admin lozinke, nakon čega bi trebao vidjeti koju od ponuđenih medicinskih usluga ima svaki od korisnika. 
Prioritet [1-5] | 2
Izvor/Porijeklo | Developer tim aplikacije

Identifikator | FZ-8
-|-
Zahtjev | Sustav omogućuje ispis svih zahtjeva za pregled koje je pacijent napravio
Obrazloženje | Pacijent nakon što se uspješno prijavi u aplikaciju će na početnom zaslonu moći vidjeti svoje zahjtebe za pregledom te će imati mogućnost ispisa svih svojih zahjteva za pregled pritiskom gumba "ispis" pokraj svakog zahtjeva.
Način provjere | Pacijent bi se trebao uspješno prijaviti u aplikaciju, nakon čega bi trebao moći vidjeti svoje zahtjeve i pokraj svakog bi trebao imati gumb "ispis". Trebao bi stisnuti taj gumb i odabrani zahtjev bi se trebao ispisati.
Prioritet [1-5] | 3
Izvor/Porijeklo | Developer tim aplikacije

## Zadatak
[Link na zadatak](https://github.com/foivz/pi2024-zadace-ibasljan22/blob/master/Korisni%C4%8Dki%20zahtjevi%20-%20Softver%20za%20osobnu%20telemedicinu.pdf)

## Resursi
(Zadaće je obvezno predati u obliku Wiki stranica na ovom repozitoriju. Slike i druge artefakte koje ćete koristiti na wiki stranicama smjestite u mapu dokumentacije u repozitoriju!)

Svi resursi nalaze se u mapi _Documentation_.
