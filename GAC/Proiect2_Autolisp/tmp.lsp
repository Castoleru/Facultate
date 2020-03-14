; returneaza ultimul element din asocierea lui i cu l

(defun dxf (i l)

  ;i- primul multime a asocierii
  ;l- a doua multime a asocierii

  (cdr (assoc i l))
  
  );dxf

;-----------------------------------------------------------------------------------------------------------------------------------------------vopsire
;Schimba culoarea layerului pentru mai multe entitati. Atat numarul de entitati cat si entitatile respective sunt
;introduse(selectate) de catre utilizator

(defun c:vopsire(/ count esel ent layer olay color)
  
	;count    - Numarul de obiecte care vor fi vobiste, numar introdus de catre utilizator
	;esel     - Lista cu numele entitatii si coordonatele entitatill
  	;ent      - Lista cu toate datele din entitatea aflata pe prima pozitie din esel
  	;layer    - Contine denumirea layerului respectiv
  	;olay     - Ttoate entitatile ce apartin layerului respectiv si informatiile genrale ale layerului
  	;color    - Reprezinta culoarea layerului
  	;newcolor - Noua culoare aleasa de utilizator
  	
  
  (setq count (getint "\n Introdu numarul de obiecte pe care vrei sa le vopsesti: "))
  (while (> count 0)
  (if
    (and
      
      	  ;Selectia entitatii
	  (setq esel (entsel "Selecteaza un obiect"))
	  (setq ent (entget (car esel)))
	  
	  ;Selectia Layerului
	  (setq layer (dxf 8 ent))
	  (setq olay (entget (tblobjname "LAYER" layer)))
	  
	  ;Selectia culorii curente si a culorii noi
	  (setq color(dxf 62 olay))
	  (setq newcolor(acad_colordlg color))
	  
	  ;Modificarea culorii in toate entitatile ce apartin layerului
	  (setq olay(subst (cons 62 newcolor)(assoc 62 olay) olay))
	  
	);and
    
     (progn
       
    	   ;Decrementarea count-ului
    	   (setq count (- count 1))
       
    	   ;Actualizarea listei olay
	   (entmod olay)
       
    	   ;Refresh pentru a observa schimbarile
	   (command "REGEN")
       
     	   ;Un mesaj pentru a arata ca schimbarile au fost efectuate cu succes
     	   (alert "Layerul a fost modificat")
       
     );progn
    
    ;Afisarea unui mesaj in cazul in care utilizatorul nu a ales un obiect
   (alert "Nu ati selectat obiectul")
    
    );if
    
   );while
  
  ); vopsire

;--------------------------------------------------------------------------------------------------------------------------------------------lumini
;face vizibile entitatile ce apartin layerului BECURI in functie de valoatea lui on 1/0
(defun c:lumini(/ on olay )
  
  	;on   - Valoarea vizibilitatii
  	;olay - Toate entitatile ce apartin layerului respectiv si informatiile genrale ale layerului
  
  (setq on (getint "\n Inchidem luminile (1) | Aprindem luminile (0)  "))
  	
	(if (or (= on 1) (= on 0))
		(progn	
		  (setq olay (entget (tblobjname "LAYER" "becuri")))
		  
		  ;Modificarea visibilitatii in toate entitatile ce apartin layerului
		  (setq olay(subst (cons 70 on)(assoc 70 olay) olay))
		  
	    	   ;Actualizarea listei olay
		   (entmod olay)
		  
	    	   ;Refresh pentru a observa schimbarile
		   (command "REGEN")
		  
		  ;Afisarea mesajului
		  (if (= on 1) (alert "Au fost stinse luminile"))
		  (if (= on 0)  (alert "Au fost aprinse luminile"))
		  
		);progn
	  
    		(alert "Valoare eronata")
    
  	);if
  
  ); lumini


