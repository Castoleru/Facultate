(defun dxf (i l) (cdr (assoc i l))	)

(defun c:vopsire(/ esel ent layer olay color int)
  (setq int (getint "\n Introdu numarul de obiecte pe care vrei sa le vopsesti: "))
  (while (> int 0)
  (if
    (and
	  (setq esel (nentsel "Selecteaza un obiect"));Selectia entitatii
	  (setq ent (entget (car esel)))
	  (setq layer (dxf 8 ent)); Selectia layerului
	  (setq olay (entget (tblobjname "LAYER" layer))); Selectia listei dorite din layer
	  (setq color(dxf 62 olay))
	  (setq newcolor(acad_colordlg color));selectia unei noi culori
	  (setq olay(subst (cons 62 newcolor)(assoc 62 olay) olay))
	);and
  (progn
    	  (setq int (- int 1))
	  (entmod olay)
	  (command "REGEN")
    	  (alert "Layerul a fost modificat")
    );progn
   (alert "Nu ati selectat obiectul")
    );if
    );while
  ); CAS


