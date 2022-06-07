# EOS-for-Excel
Libreria contenente alcune funzioni per la determinazione di grandezze stimate con le EoS cubiche.

Elia Ferretti © 2022

Il componente aggiuntivo contiene le seguenti funzioni:

1) zetaL:		funzione che restituisce il fattore di comprimibilità della fase liquida a partire dai valori di input:
				a,b,c,d definiti come coefficienti della cubica:  a*z^3 + b*z^2 + c*z + d = 0
		
2) zetaV: 		come zetaL ma per la fase vapore

3) phiRKS_L:	funzione che restituisce il coefficiente di fugacità previsto dall’equazione cubica RKS per la fase liquida di un composto puro a partire dai valori:	𝑇𝑐, 𝑝𝑐, 𝜔, 𝑇, 𝑝
				!!! Le pressioni vanno fornite in [Pa]

4) phiRKS_V:	come phiRKS_L ma per la fase vapore

5) phiPR_L:		funzione che restituisce il coefficiente di fugacità previsto dall’equazione cubica PR per la fase liquida di un composto puro a partire dai valori:	𝑇𝑐, 𝑝𝑐, 𝜔, 𝑇, 𝑝
				!!! Le pressioni vanno fornite in [Pa]

6) phiPR_V:		come phiPR_L ma per la fase vapore

7) phiRKSmix_L:	funzione che restituisce il coefficiente di fugacità previsto dall’equazione cubica RKS per la fase liquida di un composto in miscela a partire dai valori:	𝑖, x , 𝑁𝐶, 𝑇𝑐 , 𝑝𝑐 , 𝜔 , 𝑇, 𝑝
				Dove i è l’indice della specie di cui si vuole calcolare 𝛷
				x è il vettore delle frazioni molari
				Tc è il vettore delle temperature critiche
				pc è il vettore delle pressioni critiche
				w è il vettore dei fattori acentrici
				NC è il numero di componenti della miscela
				!!! Le pressioni vanno fornite in [Pa]

8) phiRKSmix_V:	come phiRKSmix_L ma per la fase vapore

9) phiPRmix_L:	funzione che restituisce il coefficiente di fugacità previsto dall’equazione cubica PR per la fase liquida di un composto in miscela a partire dai valori:	𝑖, x , 𝑁𝐶, 𝑇𝑐 , 𝑝𝑐 , 𝜔 , 𝑇, 𝑝
				Dove i è l’indice della specie di cui si vuole calcolare 𝛷
				x è il vettore delle frazioni molari
				Tc è il vettore delle temperature critiche
				pc è il vettore delle pressioni critiche
				w è il vettore dei fattori acentrici
				NC è il numero di componenti della miscela
				!!! Le pressioni vanno fornite in [Pa]

10) phiPRmix_V:	come phiPRmix_L ma per la fase vapore
