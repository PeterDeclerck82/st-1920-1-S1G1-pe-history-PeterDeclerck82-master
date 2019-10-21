# PE2 - History
## PE2 1920 sem 1

Lees eerst de volledige opgave alvorens aan deze opdracht te beginnen.

## Het grafische

![Image of start](/images/pe2_1.png)

## De opdracht
- De bedoeling is om 3 Lists bij te houden : jaartallen, gebeurtenissen en landen.
Hierin bewaren we historische gebeurtenissen (zie schermafbeelding).
- De gebruiker dient in de corresponderende tekstvakken tekst in te voeren.
Bij een klik op btnToevoegen worden de waarden in de respectievelijke Lists bewaard.
- Vooraleer aan de 3 Lists waarden worden toegevoegd, dient aan volgende voorwaarden voldaan te worden:
  - Geen van de tekstvelden mag leeg zijn
  - In txtJaartal dient een geheel getal te staan dat groter is dan -2000 en kleiner of gelijk aan het huidige kalenderjaar.  
  - In txtGebeurtenis dient een unieke waarde ingevoerd te worden. Zo vermijden we dubbele registraties.  Je dient dit wel grondig uit te werken.
    De vergelijking mag niet hoofdlettergevoelig zijn : Brugge = brugge = BRUGGE
    Speciale karakters dienen omgezet te worden : hélène = hélene = helene = hëlëne …

    Schrijf hiervoor een afzonderlijke methode die de tekst omzet.  
    Tip : overloop letter per letter en bekijk zijn ASCII waarde.
    Dit kan als leidraad helpen : 
    
             // 97 -> 122 zijn toegelaten
             // 48 -> 57 zijn toegelaten
             // 224 -> 230 wordt a
             // 231 wordt c
             // 232 -> 235 wordt e
             // 236 -> 239 wordt i
             // 241 wordt n
             // 242 -> 248 en 156 wordt o
             // 249 -> 252 wordt u
             // 253 wordt y

    Opgepast : deze omzetting dient enkel om dubbele waarden de voorkomen.
    
    In de List zelf wordt opgeslagen (na het verwijderen van eventuele voor- en naloopspaties) wat de gebruiker heeft ingevoerd.

- lblFout
  - Wordt verborgen bij het opstarten
  - Wordt getoond bij een fout
  - Toont een aangepaste foutmelding die verklaart wat er juist fout is.

    Bijvoorbeeld : bij deze invoer (in de veronderstelling dat “Slag bij Hastings” al eerder werd ingevoerd) 
    
    ![Image of fout1](/images/pe2_2.png)
    
    dient de volgende boodschap te verschijnen : 
    
     ![Image of fout2](/images/pe2_3.png)
     
- Is alles correct verlopen dan:
  - worden de 3 waarden aan de Lists toegevoegd
  - wordt de listbox lstGeschiedenis geleegd en opnieuw gevuld met alle waarden van de 3 Lists (uiteraard geconcateneerd tot 1 string) : 

    ![Image of listbox](/images/pe2_4.png)

  - wordt aan cmbLand het land toegevoegd, op voorwaarde dat het land er al niet in zat.  In de situatie in de afbeelding hierboven zit “België” 3 keer in de List landen, maar “België” mag maar 1 keer voorkomen in cmbLand.
- De ingave van een land in txtLand kan op 2 manieren gebeuren:
  - de naam van een land intikken in txtLand
  - een waarde selecteren in cmbLand en op de knop btnLandGebruiken klikken. 
    De geselecteerde waarde wordt dan naar txtLand gekopieerd : 
    
  ![Image of combobox](/images/pe2_5.png)

- Tenslotte moet het mogelijk zijn om de 3 lists te sorteren (oplopen en aflopend) op jaartal wanneer op btnSortUp en btnSortDown wordt geklikt.

  Je __MOET__ hier zelf een eigen methode voor schrijven (dus __GEEN__ gebruik maken van eventuele beschikbare sorteer methoden van de List).
  Let er vooral op dat je niet alleen de List jaartallen sorteert, maar dat je de gebeurtenissen en de landen mee verplaatst (m.a.w. dat de bouw van de Eifeltoren niet plotseling in 1302 en in de UK valt).
  
  Er zijn duizenden sites te vinden die je uitleggen hoe je lijsten en/of collections kan sorteren.
Het meest eenvoudige sorteeralgoritme is gekend onder de naam BubbleSort.  Je kan hiermee alvast aan de slag.

### Nog een laatste tip: voorlopige standaardwaarden.
Je zal je solution waarschijnlijk heel wat keren moeten opstarten om dingen na te kijken of uit te proberen.
Bespaar jezelf tijd en werk door eerst een methode te maken die al wat data in de 3 Lists (en de combobox) oplaadt, zodat je niet telkens opnieuw vanalles moet gaan invoeren voor je kunt testen. Onderstaande stukje code (dat je bij het opstarten kan oproepen) geven we je gratis mee : 

        private void Voorafje()
        {
            jaartallen.Add(1302);
            jaartallen.Add(1830);
            jaartallen.Add(1492);
            jaartallen.Add(1815);
            jaartallen.Add(1066);
            gebeurtenissen.Add("Slag der gulden sporen");
            gebeurtenissen.Add("Onafhankelijkheid");
            gebeurtenissen.Add("Ontdekking Amerika Christoffel Colombus");
            gebeurtenissen.Add("Slag bij Waterloo");
            gebeurtenissen.Add("Slag bij Hastings");
            landen.Add("België");
            landen.Add("België");
            landen.Add("Amerkika");
            landen.Add("België");
            landen.Add("UK");
            cmbLand.Items.Add("België");
            cmbLand.Items.Add("Amerika");
            cmbLand.Items.Add("UK");

            //VulGeschiedenis();
        }


