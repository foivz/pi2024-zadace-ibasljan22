# Naziv projekta
Softver za osobnu telemedicinu

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
Obrazloženje | Korisnik vrši prijavu u aplikaciju na temelju odabranog korisničkog imena i lozinke ili ako prvi puta obavlja prijavu u aplikaciju onda koristi zadane podatke koje aplikacija nudi ovisno o tome je li pacijent ili liječnik opće medicine. Nakon prijave preko vlastito odabranog korisničkog imena i lozinke korisnik će imati pristup određenim funkcijama aplikacije, ovisi o ulozi u kojoj se nalazi korisnik, softver će imati različite funkcije za pojedinačnu ulogu. Ako se korisnik prijavi kao pacijent tada će imati sve funkcije koje ima pacijent. Pregledavanje vlastite medicinske povijesti, određenu terapiju, rezultate vlastitih pretraga te stvaranje zahtjeva za pregled. Korisnik koji se prijavi kao liječnik opće medicine imat će sve funkcije koje ima liječnik opće medicine nekog pacijenta. Pripadajuće funkcije te uloge su pregled i uređivanje medicinske povijesti pacijenta, uređivanje terapije, rezultate pretraga. Liječnik će moći vidjeti koliko osoba je njega odabralo, uređivati sam zahtjev za pregledom te će moći vidjeti mail svakog od svojih pacijenata i tako ih kontaktirati vezano uz savjetovanje.
Način provjere | Upis ispravnih samostalno odabranih korisničkih podataka treba omogućiti prijavu u aplikaciju. Nakon uspješne prijave u aplikaciju trebao bit biti omogućen daljni rad u aplikaciji, ovisno o korisniku koji se prijavljuje, pacijent ili liječnik opće medicine.
Prioritet [1-5] | 1
Izvor/Porijeklo | Osiguravajuća kuća

Identifikator | FZ-2
-|-
Zahtjev | Sustav će omogućiti unos novog korisničkog imena i lozinke te unos osobnih i medicinskih podataka pacijentima i liječnicima
Obrazloženje | Svaki liječnik koji prvi puta pristupa aplikaciji će dobiti iste podatke za prijavu u sustav. Nakon što se obavi prijava liječnik odabire novo korisničko ime i vlastitu lozinku te unosi medicinske i osobne podatke (email, broj telefona, radno mjesto). Svaki pacijent koji po prvi puta koristi aplikaciju će dobiti iste podatke za prijavu u aplikaciju. Nakon što tako obave prijavu morati će odabrati novo korisničko ime i lozinku te unijeti osobne i medicinske podatke (zdravstvena iskaznica, email za kontakt, broj telefona). Nakon toga liječnik ili pacijent se ponovno prijavljuju u aplikaciju pomoću odabranih korisničkih imena i lozinki. Dalje će moći koristiti određene funkcije aplikacije ovisno o tome koju ulogu imaju, liječnik opće medicine ili pacijent.
Način provjere | Upis već zadanih korisničkih podataka za ulogu pacijenta ili liječnika opće prakse treba omogućiti prijavu u aplikaciju te bi trebali dalje moći unijeti nove podatke, novo korisničko ime i lozinku te unijeti osobne i medicinske podatke. Nakon toga se vrši ponovna prijava u aplikaciju pomoću odabranog korisničkog imena i lozinke. Nakon uspješne prijave u aplikaciju trebao bi biti omogućen daljni rad u aplikaciji, ovisno o korisniku koji se prijavljuje, pacijent ili liječnik opće medicine.
Prioritet [1-5] | 1
Izvor/Porijeklo | Osiguravajuća kuća

Identifikator | FZ-3
-|-
Zahtjev | Sustav će omogućiti odabir i pretplatu na jednu od ponuđenih zdravstvenih usluga te prikaz na koju su uslugu točno pretplaćeni svakom autentificiranom pacijentu
Obrazloženje | Pacijenti odmah čim se ulogiraju u aplikaciju imati će odmah prikazane ponuđene zdravstvene usluge. Pacijentima će biti omogućena fleksibilnost u odabiru paketa koji najbolje odgovaraju njihovim potrebama i financijskim mogućnostima. Prije nego što odaberu ikakvu uslugu, u desnom gornjem kutu ispod imena će im pisati da nemaju aktivnu uslugu, dokle god se ne pretplate na neku uslugu neće imati pristup funkcijama aplikacije. Nakon što odaberu svoju uslugu i odrade plaćanje, u desnom gornjem kutu ispod svoga imena će im pisati koju uslugu trenutno imaju i nakon toga će imati na raspolaganju odabir jednog od dostupnih i ugovorenih liječnika opće medicine
Način provjere | Nakon što se pacijenti ulogiraju u aplikaciju pomoću vlastitog korisničkog imena i lozinke trebao bi odmah na ekranu vidjeti ponuđene usluge koje nudi aplikacija. Isto tako trebali bi vidjeti u gornjem desnom kutu ispod svoga imena da nemaju aktivnu uslugu. Trebaju odabrati jednu od ponuđenih usluga te obaviti plaćanje. Nakon što uspješno obave plaćanje na ekranu bi im se trebalo pokazati lista dostupnih i ugovorenih liječnika te na gornjem desnom kutu ispod svoga imena će vidjeti da imaju jednu od dostupnih usluga.
Prioritet [1-5] | 2
Izvor/Porijeklo | Osiguravajuća kuća

Identifikator | FZ-4
-|-
Zahtjev | Sustav će omogućit odabir jednog od dostupnih i ugovorenih liječnika svakome autentificiranom pacijentu
Obrazloženje | Nakon što se pacijent uspješno prijavi u aplikaciju te obavi plaćanje odabrane usluge, na početnom ekranu će moći vidjeti listu liječnika na kojoj mora odabrati jednoga od ponuđenih i ugovorenih liječnika opće medicine. Nakon odabira jednog od liječnika moći će stvarati i slati zahjteve za pregled tome liječniku.    
Način provjere | Nakon što se pacijent uspješno prijavi u aplikaciju preko vlastitog korisničkog imena i lozinke te odabere i obavi plaćanje jedne od usluga trebao bi moći vidjeti listu svih dostupnih i ugovorenih liječnika. Nakon što pacijent odabere svoga liječnika trebao bi moći stvarati i slati zahtjeve tome liječniku. 
Prioritet [1-5] | 1
Izvor/Porijeklo | Osiguravajuća kuća

Identifikator | FZ-5
-|-
Zahtjev | Sustav će omogućiti stvaranje zahtjeva za pregled svim autentificiranim pacijentima
Obrazloženje | Nakon što se pacijent uspješno prijavi u aplikaciju i obavio je odabir i plaćanje svoje usluge te odabir svoja liječnika, imati će mogućnost stvaranja zahtjeva za pregled i slanje toga zahtjeva svome liječniku. U samom zahtjevu će opisati svoj problem, napisati vrijeme preferiranog termina, odabrati ima li mogućnost video poziva ili ne. Također pacijent će imati opciju da klikne gumb za slanje zahtjeva te gumb da odustane od slanja. Liječnik kada primi zahtjev trebao bi ga pročitati te odmah ići poslati pacijentu na mail link na zoom poziv ukoliko je pacijent stavio da za mogućnost video poziva. Ako je u mogućnosti za video poziv onda bi dobio link na zoom poziv gdje bi dalje pacijent trebao detaljnije objasniti svoj problem svome liječniku, u suprotnom bi preko telefona trebali komunicirati. Opis u zahtjevu služi kao kratak naputak liječniku, da dobije generalnu informaciju što je problem.
Način provjere | Nakon uspješne prijave pacijenta preko vlastitog korisničkog imena i lozinke te odrađenog odabira i plaćanja usluge i odabira vlastitog liječnika, pacijent bi trebao moći stvoriti zahtjev za pregled. U zahjtev stavlja opis svoga problema, odabire vrijeme preferiranog termina, može li na video poziv te odabire opciju pošalji, zahjtev ide direktno liječniku kojega je odabrao. 
Prioritet [1-5] | 2
Izvor/Porijeklo | Osiguravajuća kuća

Identifikator | FZ-6
-|-
Zahtjev | Sustav će omogućiti pregled liste zahtjeva za pregled svakom autentificiranom liječniku
Obrazloženje | Liječnik kada se uspješno prijavi u aplikaciju će odmah na ekranu imati pregled svih zahtjeva koje je dobio od svojih pacijenata. Moći će vidjeti ime i prezime pacijenta, status zahtjeva je li u novi, u tijeku ili gotov te će moći vidjeti kratak opis zahtjeva kojega je napisao pacijent. Liječnik će moći otvoriti svaki od zahtjeva te u njemu dopisivati i uređivati stvari ovisno o nalazima, rezultatima pretraga koje dobije te na temelju razgovora sa pacijentom.
Način provjere | Nakon što se liječnik uspješno prijavi u aplikaciju pomoću odabranog korisničkog imena i lozinke trebao bi odmah na ekranu imati pregled svih zahtjeva koje je dobio od svojih pacijenata.
Prioritet [1-5] | 3
Izvor/Porijeklo | Osiguravajuća kuća

Identifikator | FZ-7
-|-
Zahtjev | Sustav će omogućiti uređivanje svih zahtjeva za pregled svakom autentificiranom liječniku
Obrazloženje | Liječnik nakon što se uspješno prijavi u aplikaciju, odmah na ekranu će vidjeti sve zahjteve koje je dobio od pacijenata. Nakon što klikne na jedan u njemu će moći dodavati određene informacije koje su bitne za pacijenta. Unosi informacije na temelju dobivenih nalaza svoga pacijenta, na temelju pretraga i drugo. Mijenja status samog zahtjeva u tijeku ili gotov, ovisi je li još na tom pacijentu ili je pacijentu bolje. 
Način provjere | Nakon što se liječnik uspješno prijavi u aplikaciju preko vlastitog korisničkog imena i lozinke trebao bi imati pregled svih zahtjeva za pregled koje je dobio od svojih pacijenata. Trebao bi moći kliknuti na svaki od njih te tako ući u sam zahtjev gdje će moći uređivati i dodavati određene informacije bitne za pacijenta.
Prioritet [1-5] | 1
Izvor/Porijeklo | Osiguravajuća kuća


Identifikator | FZ-8
-|-
Zahtjev | Sustav će omogućiti pregled statističkih podatka korištenja pojedine medicinske usluge developer timu aplikacije
Obrazloženje | Developer timu aplikacije će biti omogućen uvid u podatke o tome koju točno uslugu koristi koji korisnik, koliko korisnika koristi koju uslugu te će moći sve te podatke vidjeti u obliku grafa.
Način provjere | Član developer tima bi se trebao prijaviti u aplikaciju preko admin korisničkog imena i admin lozinke, nakon čega bi trebao vidjeti koju od ponuđenih medicinskih usluga ima svaki od korisnika te će moći sve te podatke vidjeti u obliku grafa. 
Prioritet [1-5] | 3
Izvor/Porijeklo | Osiguravajuća kuća

Identifikator | FZ-9
-|-
Zahtjev | Sustav će omogućiti pregled svih zahtjeva za pregled koje je napravio pacijent 
Obrazloženje | Pacijent kad se uspješno prijavi u aplikaciju te odabere i plati uslugu, odabere liječnika, na ekranu će vidjeti zahtjeve za pregled koje je poslao svome liječniku, ako ih ima. Vidjeti će datum kad je poslan, opis koji je stavio te status zahtjeva. Novi, znaći da ga liječnik još nije vidio, u tijeku, znači da liječnik pregledava zahtjev ili čeka nalaze pretraga koje je pacijent obavio, gotov, znači da mu je liječnik pomogao sa medicinskim problemom.
Način provjere | Nakon što se pacijent uspješno prijavi u aplikaciju pomoću vlastitog korisničkog imena i lozinke, odabrane i plaćene usluge i odabranog liječnika, trebao bi vidjeti zahtjeve koje je napravio za liječnika, ako je napravio ikakav zahtjev. Trebao bi vidjeti svoje ime i prezime, opis te status zahtjeva.
Prioritet [1-5] | 3
Izvor/Porijeklo | Osiguravajuća kuća


## Zadatak
[Link na zadatak](https://github.com/foivz/pi2024-zadace-ibasljan22/blob/master/Korisni%C4%8Dki%20zahtjevi%20-%20Softver%20za%20osobnu%20telemedicinu.pdf)

## Resursi
Svi resursi nalaze se u mapi _Documentation_.
