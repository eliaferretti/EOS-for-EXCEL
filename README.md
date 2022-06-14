Elia Ferretti © 2022

Il componente aggiuntivo contiene le seguenti funzioni:

!!TUTTE LE VARIABILI VANNO FORNITE (E VENGONO RESTITUITE) NELLE UNITA' DEL SISTEMA INTERNAZIONALE!!

1) zeta_VdW:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")
				
2) zeta_RK:			funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")		
				
3) zeta_RKS:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					w 			[-] è il fattore acentrico di Pitzer del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")
				
4) zeta_PR:			funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					w 			[-] è il fattore acentrico di Pitzer del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")

5) phi_VdW:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")
				
6) phi_RK:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")		
				
7) phi_RKS:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					w 			[-] è il fattore acentrico di Pitzer del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")
				
8) phi_PR:			funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					w 			[-] è il fattore acentrico di Pitzer del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")

9) hR_VdW:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica VdW di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					T 			[K] è la temperatura
					pressure 		[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")
				
10) hR_RK:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RK di un composto puro a partire dai valori Tc,pc,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")		
				
11) hR_RKS:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RKS di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					w 			[-] è il fattore acentrico di Pitzer del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")
					
12) hR_PR:			funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica PR di un composto puro a partire dai valori Tc,pc,w,T,pressure,state dove:
					Tc 			[K] è la temperatura critica del composto puro
					pc 			[Pa] è la pressione critica del composto puro
					w 			[-] è il fattore acentrico di Pitzer del composto puro
					T 			[K] è la temperatura
					pressure 	[Pa] è la pressione
					state 		[-] è una stringa rappresentante la fase del composto ("V" o "L")

13) zeta_VdWmix:	funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")
				
14) zeta_RKmix:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	
					
15) zeta_RKSmix:	funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	
					
16) zeta_PRmix:		funzione che restituisce il fattore di comprimibilità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	

17) phi_VdWmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica VdW di un composto puro a partire dai valori index,x,NC,Tc,pc,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC)
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	
				
18) phi_RKmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RK di un composto puro a partire dai valori index,x,NC,Tc,pc,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC)
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	
					
19) phi_RKSmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica RKS di un composto puro a partire dai valori index,x,NC,Tc,pc,w,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC)
					Tc 		[K] è la temperatura critica del composto puro
					pc 		[Pa] è la pressione critica del composto puro
					w 		[-] è il fattore acentrico di Pitzer del composto puro
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase del composto ("V" o "L")
				
20) phi_PRmix:		funzione che restituisce il coefficiente di fugacità [-] previsto dall’equazione cubica PR di un composto puro a partire dai valori index,x,NC,Tc,pc,w,T,pressure,state dove:
					index   [-] è l'indice della specie di interesse (indice rispetto a uno dei seguenti vettori, dev'essere un numero tra 1 e NC)
					Tc 		[K] è la temperatura critica del composto puro
					pc 		[Pa] è la pressione critica del composto puro
					w 		[-] è il fattore acentrico di Pitzer del composto puro
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase del composto ("V" o "L")

21) hR_VdWmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica VdW di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	
				
22) hR_RKmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RK di un composto puro a partire dai valori x,NC,Tc,pc,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	
				
23) hR_RKSmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica RKS di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	
				
24) hR_PRmix:		funzione che restituisce l' entalpia residua [J/mol] prevista dall’equazione cubica PR di un composto puro a partire dai valori x,NC,Tc,pc,w,T,pressure,state dove:
					x		[-] è il vettore delle composizioni
					NC		[-] è il numero di componenti (dimensione del vettore x)
					Tc 		[K] è il vettore delle temperature critiche dei composti puri
					pc 		[Pa] è il vettore delle pressioni critiche dei composti puri
					w 		[-] è il vettore dei fattori acentrici di Pitzer dei composti puri
					T 		[K] è la temperatura
					p 		[Pa] è la pressione
					state 	[-] è una stringa rappresentante la fase della miscela ("V" o "L")	


Per qualsiasi problema o bug si contatti lo sviluppatore all'indirizzo: eliaferretti@outlook.it

